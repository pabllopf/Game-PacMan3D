//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Ghost.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.AI;

/// <summary>Main enemy of the videogame</summary>
public class Ghost : MonoBehaviour
{
    public int distance = 10;
    public GameObject bullet;
    public float timeToShot = 1f;
    private Transform target;
    private NavMeshAgent navMeshAgent;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, target.position) <= distance)
        {
            if (timeToShot <= 0)
            {
                Instantiate(bullet, this.transform.position + new Vector3(0,1,0), Quaternion.identity);
                timeToShot = 1f;
            }
            else 
            {
                timeToShot -= Time.deltaTime;
            }
            navMeshAgent.destination = this.transform.position;
        }
        else
        {
            navMeshAgent.destination = target.transform.position;
        }

        

    }
}
