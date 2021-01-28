using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControl
{
    public class CharacterMovement : MonoBehaviour
    {
        public CharacterController controller;
        public int speed = 10;
        public int rotationSpeed = 100;
        public float gravity = -9.81f;
        public float jump = 1.0f;
        public bool grounded = false;
        public Vector3 velocity;

        // Start is called before the first frame update
        void Awake()
        {
            controller = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            if(controller.isGrounded)
            {
                grounded = true;
            }

            if(grounded && velocity.y < 0)
            {
                velocity.y = 0;
            }

            float rotY = Input.GetAxis("Horizontal");
            float moveIntensity = Input.GetAxis("Vertical");
            
            
            Vector3 move = transform.forward * moveIntensity * speed * Time.deltaTime;
            
            controller.Move(move);

            transform.RotateAround(transform.position, new Vector3(0, 1, 0), rotY * Time.deltaTime * rotationSpeed);

            if(Input.GetButtonDown("Jump") && grounded)
            {
                velocity.y += Mathf.Sqrt(jump * gravity * -3.0f);
                grounded = false;
            }

            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }
}
