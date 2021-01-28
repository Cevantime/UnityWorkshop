using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace UnityDungeon
{
    public class NavigationMovement : MonoBehaviour
    {
        private NavMeshAgent agent;
        public new Camera camera;

        void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        void Update()
        {
            if(Input.GetButtonDown("Fire1"))
            {
                Ray ray = camera.ScreenPointToRay(Input.mousePosition);

                RaycastHit hit;

                if(Physics.Raycast(ray, out hit))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
    }
}
