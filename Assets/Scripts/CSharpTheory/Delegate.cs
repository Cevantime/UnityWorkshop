using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpTheory
{
    public class Delegate
    {
        delegate float MyDelegate(float i1, float i2);

        MyDelegate myDelegate;

        public Delegate()
        {
            myDelegate = Divide;
            myDelegate += Add;

            float r = myDelegate(16,4);
            Debug.Log(r);
        }

        float Add(float i1, float i2)
        {
            Debug.Log("Add");
            return i1 + i2;
        }

        float Divide(float i1, float i2)
        {
            Debug.Log("Divide");
            return i1 / i2;
        }
    }
}
