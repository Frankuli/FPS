using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    public Transform groundCheck;
    public LayerMask groundMask;

    public float speed = 10;
    public float sphereRadius = 0.3f;
    public float jumpHeight = 2;

    private float gravity = -9.81f;
    private Vector3 velocity;




    void Update()
    {
        Move();
        Jump();




    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);//es una formula matematica para saltar
        }                                                       //si tuviera rigidbody usaria addforce
    }

    void Move()
    {
        Gravity();

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        characterController.Move(move * speed * Time.deltaTime);
    }

    void Gravity()
    {
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
        
        if (IsGrounded() && velocity.y < 0)//cuando este en suelo
        {
            velocity.y = -2f;//cae con velocidad estable
        }
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, sphereRadius, groundMask);
    }
}
