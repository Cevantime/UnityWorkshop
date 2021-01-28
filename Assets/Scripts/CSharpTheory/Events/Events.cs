using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CSharpTheory.Events
{
    public class Events
    {
        public delegate void MyEventDelegate(int a, int b);
        public event MyEventDelegate myEvent;

        public event EventHandler<EventArgs> emptyHandler; 

        public event EventHandler<MyEventArgs> twoIntsHandler;

        public void EmitMyEvent()
        {
            // DOING IMPORTANT STUFF
            // AND THEN NOTIFYING LISTENERS
            myEvent.Invoke(42, 1001);
        }

        public void EmitEmptyHandler()
        {
            emptyHandler.Invoke(this, EventArgs.Empty);
        }

        public void EmitTwoIntsHandler()
        {
            twoIntsHandler.Invoke(this, new MyEventArgs(42, 1001));
        }
    }
}
