//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Ghost.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.AI;

/// <summary>Main enemy of the videogame</summary>
public class Ghost : MonoBehaviour
{
    /// <summary>The bullet</summary>
    [SerializeField]
    private GameObject bullet = null;

    /// <summary>The time to shot</summary>
    [SerializeField]
    private float timeToShot = 1f;

    /// <summary>The distance</summary>
    [SerializeField]
    private float distance = 10f;

    /// <summary>The target</summary>
    private Transform target = null;

    /// <summary>The mesh agent</summary>
    private NavMeshAgent navMeshAgent = null;

    /// <summary>Starts this instance.</summary>
    private void Start()
    {
        this.target = GameObject.FindGameObjectWithTag("Player").transform;
        this.navMeshAgent = this.GetComponent<NavMeshAgent>();
        this.navMeshAgent.stoppingDistance = this.distance;
    }

    /// <summary>Updates this instance.</summary>
    private void Update()
    {
        this.LookAtPlayer();
        this.MoveToTarget();
        this.Shoot();
    }

    /// <summary>Looks at player.</summary>
    private void LookAtPlayer()
    {
        if (Input.GetAxis("Horizontal") < 0 && this.transform.position.x - this.target.position.x >= 0)
        {
            this.transform.LookAt(transform.position + new Vector3(0, 0, 0.1f));
        }

        if (Input.GetAxis("Horizontal") > 0 && this.transform.position.x - this.target.position.x < 0)
        {
            this.transform.LookAt(transform.position + new Vector3(0, 0, -0.1f));
        }

        if (Input.GetAxis("Vertical") < 0 && this.transform.position.z - this.target.position.z >= 0)
        {
            this.transform.LookAt(transform.position + new Vector3(-0.1f, 0, 0));
        }

        if (Input.GetAxis("Vertical") > 0 && this.transform.position.z - this.target.position.z < 0)
        {
            this.transform.LookAt(transform.position + new Vector3(0.1f, 0, 0));
        }
    }

    /// <summary>Moves to target.</summary>
    private void MoveToTarget()
    {
        this.navMeshAgent.destination = this.target.transform.position;
    }

    /// <summary>Shoots this instance.</summary>
    private void Shoot() 
    {
        if (Vector3.Distance(this.transform.position, this.target.position) <= this.distance)
        {
            if (this.timeToShot <= 0)
            {
                this.timeToShot = 1f;
                GameObject obj = Instantiate(this.bullet, this.transform.position + new Vector3(0, 0.5f, 0), Quaternion.identity);
                obj.GetComponent<Bullet>().SetTarget(this.target);
            }
            else
            {
                this.timeToShot -= Time.deltaTime;
            }
        }
    }
}
