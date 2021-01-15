using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpTheory.Inheritance {
    public class ChildClass : ParentClass {
        private int mp;

        public ChildClass (string name, int age, int hp, int mp) : base (name, age, hp)
        {
            this.mp = mp;
        }

        public override void Attack (ParentClass character)
        {
            character.SetHp (character.GetHp () - 7);
            mp -= 2;
        }

        public int GetMp () {
            return mp;
        }

        public void SetMp (int mp) {
            this.mp = Mathf.Max (0, mp);
        }
    }

}