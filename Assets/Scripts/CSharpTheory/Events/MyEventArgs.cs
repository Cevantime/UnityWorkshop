using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CSharpTheory.Events
{
    public class MyEventArgs : EventArgs
    {
        public int A { get; }
        public int B { get; }

        public MyEventArgs(int a, int b)
        {
            A = a;
            B = b;
        }
    }
}
