using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpTheory
{
    public class Properties
    {
        private int seconds;

        public float Hours
        {
            set 
            {
                seconds = (int)value * 3600;
            }

            get
            {
                return (float)seconds / 3600;
            }
        }

        public float Minutes
        {
            set 
            {
                seconds = (int)value * 60;
            }

            get
            {
                return (float)seconds / 60;
            }
        }
    }
}

