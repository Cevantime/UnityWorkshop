using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpTheory.Interface
{
    public class Attacker : IMyInterface
    {
        public void Attack()
        {
            Debug.Log("I'm attacking");
        }
    }

}
