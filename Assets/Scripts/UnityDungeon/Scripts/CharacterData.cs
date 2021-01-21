using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityDungeon {
    [CreateAssetMenu (fileName = "New Character", menuName = "CustomScripts/Character")]
    public class CharacterData : ScriptableObject {
        public new string name;
        public int maxHP;
        public int strength;
        public int defense;
        public int intelligence;

        private float currentHP;
        public int HP 
        {
            get {
                return Mathf.RoundToInt (currentHP);
            }
        }

        void OnEnable()
        {
            currentHP = maxHP;
        }

        public void TakeDamage (float damage) {
            currentHP = Mathf.Max (currentHP - damage, 0);
            // currentHP -= damage;
            // if(currentHP < 0)
            // {
            //     currentHP = 0;
            // }
        }

        public void Heal (float health) {
            currentHP = Mathf.Min (currentHP + health, maxHP);
            // currentHP += health;
            // if(currentHP > maxHP)
            // {
            //     currentHP = maxHP;
            // }
        }
    }
}