//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Player.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;

/// <summary>Control the main player.</summary>
public class Player : MonoBehaviour
{
    public GameObject pacman;
    public float speed = 6.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            pacman.transform.LookAt(transform.position + new Vector3(-0.1f, 0, 0));
            this.moveDirection = new Vector3(-1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            pacman.transform.LookAt(transform.position + new Vector3(0.1f,0,0));
            this.moveDirection = new Vector3(1f, 0, 0);
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            pacman.transform.LookAt(transform.position + new Vector3(0, 0, 0.1f));
            this.moveDirection = new Vector3(0, 0, 1f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            pacman.transform.LookAt(transform.position + new Vector3(0, 0, -0.1f));
            this.moveDirection = new Vector3(0, 0, -1f);
        }

        
    }

    private void FixedUpdate()
    {
        this.transform.Translate(moveDirection.x * speed * Time.deltaTime, 0, moveDirection.z * speed * Time.deltaTime);
    }
}
