using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpTheory
{
    public class Lists
    {
        
        public void initialize()
        {
            List<int> myList = new List<int>();

            myList.Add(5);
            myList.Add(6);

            int a = myList[0];
            int b = myList[1];

            Debug.Log($"a = {a} et b = {b}");

            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            int c = myQueue.Dequeue();
            int d = myQueue.Dequeue();

            Debug.Log($"c = {c} et d = {d}");

            Stack<int> myStack = new Stack<int>();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            int e = myStack.Pop();
            int f = myStack.Peek();

            Debug.Log($"e = {e} et f = {f}");
            Debug.Log($"stack size {myStack.Count}");

            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("Toto", 1);
            dict.Add("Tata", 2);

            int g = dict["Toto"];
            int h;

            if(dict.TryGetValue("Tata", out h))
            {
                Debug.Log($"h = {h}");
            }
        }
        

    }
}
