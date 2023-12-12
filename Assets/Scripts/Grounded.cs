using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        controller.Move(direction * speed * Time.deltaTime);

        if (controller.isGrounded)
        {
            controller.Move(new Vector3(0, -controller.velocity.y, 0));
        }
    }
}
