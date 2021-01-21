﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace UnityDungeon
{
    public class FightScript : MonoBehaviour
    {
        public TextMeshProUGUI textMesh;
        public CharacterData player;
        public CharacterData ennemy;
        public GameObject buttons;

        public TextMeshProUGUI hpPlayer;
        public TextMeshProUGUI hpEnnemy;

        public RevealText revealText;
        public int attackIntensity = 5;

        [Tooltip("A floating number between 0 and 1")]
        public float healIntensity = 0.3f;

        public enum FightState
        {
            BEGIN,
            WAITING,
            PLAYER_TURN,
            ENNEMY_TURN,
            END
        }

        private FightState state;

        // Start is called before the first frame update
        IEnumerator Start()
        {
            state = FightState.BEGIN;
            yield return ChangeText($"{ennemy.name} apparaît.");
            updateHUD();
            state = FightState.WAITING;
        }

        IEnumerator ChangeText(string text)
        {
            yield return StartCoroutine(revealText.ChangeText(text));
        }

        void updateHUD()
        {
            hpPlayer.text = $"{player.HP}/{player.maxHP}";
            hpEnnemy.text = $"{ennemy.HP}/{ennemy.maxHP}";
        }

        IEnumerator Attack(CharacterData attacker, CharacterData target)
        {
            float damage = ((float)attacker.strength / target.defense) * attackIntensity;
            int previousHP = target.HP;
            target.TakeDamage(damage);
            int diff = previousHP - target.HP;
            yield return StartCoroutine(ChangeText($"{attacker.name} attaque {target.name} et lui fait perdre {diff}PV!"));
            updateHUD();
            yield return new WaitForSeconds(1.0f);
        }

        IEnumerator Heal(CharacterData character)
        {
            float health = character.intelligence * healIntensity;
            int previousHP = character.HP;
            character.Heal(health);
            int diff = character.HP - previousHP;
            yield return StartCoroutine(ChangeText($"{character.name} se soigne et récupère {diff}PV!"));
            updateHUD();
            yield return new WaitForSeconds(1.0f);
        }

        public void OnAttackButtonPressed()
        {
            if(state == FightState.WAITING)
            {
                StartCoroutine(PlayerAttack());
            }
        }

        IEnumerator PlayerAttack()
        {
            buttons.SetActive(false);
            state = FightState.PLAYER_TURN;
            yield return StartCoroutine(Attack(player, ennemy));
            if(ennemy.HP == 0)
            {
                EndGame(true);
            }
            else
            {
                yield return StartCoroutine(EnnemyTurn());
            }
        }

        IEnumerator EnnemyTurn()
        {
            state = FightState.ENNEMY_TURN;
            if(Random.Range(0f, 2f) < 1f)
            {
                yield return StartCoroutine(Attack(ennemy, player));
                if(player.HP == 0)
                {
                    EndGame(false);
                }
                else
                {
                    RestartInteraction();
                }
            }
            else
            {
                yield return StartCoroutine(Heal(ennemy));
                RestartInteraction();
            }
        }

        void RestartInteraction()
        {
            StartCoroutine(ChangeText("Que souhaitez-vous faire ?"));
            state = FightState.WAITING;
            buttons.SetActive(true);
        }

        public void OnHealButtonPressed()
        {
            if(state == FightState.WAITING)
            {
                StartCoroutine(PlayerHeal());
            }
        }

        IEnumerator PlayerHeal()
        {
            buttons.SetActive(false);
            yield return StartCoroutine(Heal(player));
            yield return StartCoroutine(EnnemyTurn());
        }

        void EndGame(bool won)
        {
            buttons.SetActive(false);
            state = FightState.END;
            StartCoroutine(ChangeText(won ? "Vous avez gagné." : "Vous avez perdu."));
        }

    }
}