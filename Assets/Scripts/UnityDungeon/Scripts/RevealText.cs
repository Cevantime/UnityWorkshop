using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace UnityDungeon
{
    public class RevealText : MonoBehaviour
    {
        private TextMeshProUGUI textMesh;

        void Start()
        {
            textMesh = GetComponent<TextMeshProUGUI>();
        }

        public IEnumerator ChangeText(string text)
        {
            StopCoroutine(Reveal());
            textMesh.maxVisibleCharacters = 0;
            textMesh.text = text;
            yield return StartCoroutine(Reveal());
        }

        IEnumerator Reveal()
        {
            for(int i = 0; i <= textMesh.text.Length; i++)
            {
                textMesh.maxVisibleCharacters = i;
                yield return new WaitForSeconds(0.05f);
            }
        }
    }
}
