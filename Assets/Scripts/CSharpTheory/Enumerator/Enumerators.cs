using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpTheory.Enumerator
{
    public class Enumerators
    {
        public IEnumerator myEnumerator()
        {
            for(int i = 0; i <= 20; i += 2)
            {
                yield return i;
            }
        }
    }
}
