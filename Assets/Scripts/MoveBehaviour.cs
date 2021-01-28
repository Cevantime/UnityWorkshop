using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CSharpTheory;
using CSharpTheory.Inheritance;
using CSharpTheory.Genericity;
using MemberHiding = CSharpTheory.MemberHiding;
using CSharpTheory.Interface;
using CSharpTheory.Enumerator;
using CSharpTheory.Events;
using System;

public class MoveBehaviour : MonoBehaviour
{
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        // Properties p = new Properties();
        // p.Hours = 30;
        // Debug.Log(p.Minutes); // 1800
        // p.Minutes = 30;
        // Debug.Log(p.Hours); // 0.5

        // StaticFields.monChamp = 10;

        // Singleton.Instance.groupName = "New name";
        // Singleton.Instance.nbGroup = 42;

        // MethodOverloading mo = new MethodOverloading();
        // mo.text("Hello world !!");

        // Debug.Log(mo.text());

        // ParentClass c1 = new ParentClass("Jean", 42, 20);
        // ParentClass c2 = new ChildClass("Marion", 45, 17, 15);

        // c1.attack(c2);

        // Debug.Log(c1.getHp()); // 20
        // Debug.Log(c2.getHp()); // 12

        // c2.attack(c1);
        // Debug.Log(c1.getHp()); // 13
        // Debug.Log(c2.getHp()); // 12
        // Debug.Log(((ChildClass)c2).getMp()); // 13

        // Group<User> userGroup = new Group<User>();

        // Female female = new Female();
        // userGroup.AddUser(female);
        // Male male = new Male();
        // userGroup.AddUser(male);
        // User user = new User();
        // userGroup.AddUser(user);

        // foreach(User u in userGroup.GetList())
        // {
        //     Debug.Log(u.SelfDescribe());
        // }

        // MemberHiding.ParentClass parent = new MemberHiding.ParentClass();
        // MemberHiding.ParentClass child = new MemberHiding.ChildClass();

        // Debug.Log(parent.Name);
        // Debug.Log(child.Name);

        // IMyInterface attacker = new Attacker();

        // attacker.Attack();

        // Enumerators enumerators = new Enumerators();
        // IEnumerator enumerator = enumerators.myEnumerator();
        // while(true) {
        //     if(enumerator.MoveNext()) {
        //         Debug.Log(enumerator.Current);
        //     } else {
        //         break;
        //     }
        // }

        // Delegate d = new Delegate();

        // Lists l = new Lists();

        // l.initialize();

        Events evs = new Events();
        
        evs.myEvent += PrintNumbers;
        evs.myEvent += AddNumbers;

        evs.EmitMyEvent();

        evs.emptyHandler += ReactToEmptyHandler;

        evs.EmitEmptyHandler();

        evs.twoIntsHandler += ReactToTwoIntsHandler;

        evs.EmitTwoIntsHandler();
        
    }

    void PrintNumbers(int a, int b)
    {
        Debug.Log("Print Numbers !");
        Debug.Log(a);
        Debug.Log(b);
    }

    void AddNumbers(int a, int b)
    {
        Debug.Log("Add Numbers !");
        Debug.Log(a + b);
    }

    void ReactToEmptyHandler(object sender, EventArgs args)
    {
        Debug.Log("React To Empty Handler !");
        Debug.Log(sender);
        Debug.Log(args);
    }

    void ReactToTwoIntsHandler(object sender, MyEventArgs twoIntsArgs)
    {
        Debug.Log("React To Two Ints Handler !");
        Debug.Log(sender);
        Debug.Log(twoIntsArgs.A + twoIntsArgs.B);
    }

    // Update is called once per frame
    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        Vector3 velocity = new Vector3(inputH, 0, inputV);
        transform.Translate(velocity * speed * Time.deltaTime);
    }
}
