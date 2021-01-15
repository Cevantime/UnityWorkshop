using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpTheory.Inheritance
{
    public class ParentClass
    {
        public string name;
        protected int age;
        protected int hp;

        public ParentClass(string name, int age, int hp)
        {
            this.name = name;
            this.age = age;
            this.hp = hp;
        }

        public virtual void Attack(ParentClass character)
        {
            character.SetHp(character.GetHp() - 5);
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            if(age < 0)
            {
                return;
            }
            this.age = age;
        }

        public int GetHp()
        {
            return hp;
        }

        public void SetHp(int hp)
        {
            this.hp = Mathf.Max(0, hp);
        }
    }
}
