using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpTheory
{
    public class MethodOverloading
    {
        private string textContent;

        public string text()
        {
            return textContent;
        }

        public void text(string text)
        {
            textContent = text;
        }
    }

}
