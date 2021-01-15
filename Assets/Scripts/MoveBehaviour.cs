using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CSharpTheory;
using CSharpTheory.Inheritance;
using CSharpTheory.Genericity;
using MemberHiding = CSharpTheory.MemberHiding;
using CSharpTheory.Interface;

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

        MemberHiding.ParentClass parent = new MemberHiding.ParentClass();
        MemberHiding.ParentClass child = new MemberHiding.ChildClass();

        Debug.Log(parent.Name);
        Debug.Log(child.Name);

        // IMyInterface attacker = new Attacker();

        // attacker.Attack();
        
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
