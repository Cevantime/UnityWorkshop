using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpTheory
{

    public class Singleton
    {
        private static Singleton instance;

        public string groupName = "Default Name";
        public int nbGroup = 0;

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Singleton()
        {

        }
    }
}
