//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Player.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI;

/// <summary>Control the main player.</summary>
public class Player : MonoBehaviour
{
    public GameObject pacman;
    public float speed = 6.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;

    public int bullets;
    public Text amountBullets;
    
    [SerializeField]
    private GameObject bullet = null;

    public GameObject target;

    public GameObject spawnenemy;

    private void Start()
    {
        Time.timeScale = 1;
        bullets = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            pacman.transform.LookAt(transform.position + new Vector3(-0.1f, 0, 0));
            this.moveDirection = new Vector3(-1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            pacman.transform.LookAt(transform.position + new Vector3(0.1f,0,0));
            this.moveDirection = new Vector3(1f, 0, 0);
        }
        
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            pacman.transform.LookAt(transform.position + new Vector3(0, 0, 0.1f));
            this.moveDirection = new Vector3(0, 0, 1f);
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            pacman.transform.LookAt(transform.position + new Vector3(0, 0, -0.1f));
            this.moveDirection = new Vector3(0, 0, -1f);
        }

        if (target) 
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                Shoot();
            }
        }
        
    }

    private void FixedUpdate()
    {
        this.transform.Translate(moveDirection.x * speed * Time.deltaTime, 0, moveDirection.z * speed * Time.deltaTime);
    }

    public void TakeBullet() 
    {
        this.bullets++;
        this.amountBullets.text = this.bullets.ToString();
    }

    public void Shoot() 
    {
        if (this.bullets > 0) 
        {
            target.GetComponent<Ghost>().StopATime();
            target.transform.position = spawnenemy.transform.position;
            bullets--;
            this.amountBullets.text = this.bullets.ToString();
        }
    }

    public void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.CompareTag("Enemy")) 
        {
            target = obj.gameObject;
        }
    }

}
