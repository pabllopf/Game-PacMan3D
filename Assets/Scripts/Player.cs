//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Player.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;

/// <summary>Control the main player.</summary>
public class Player : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = 20.0f;

    private CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetAxis("Horizontal") < 0) 
            {
                this.transform.LookAt(transform.position + new Vector3(-0.1f, 0, 0));
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                this.transform.LookAt(transform.position + new Vector3(0.1f,0,0));
            }

            if (Input.GetAxis("Vertical") < 0)
            {
                this.transform.LookAt(transform.position + new Vector3(0, 0, -0.1f));
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                this.transform.LookAt(transform.position + new Vector3(0, 0, 0.1f));
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
