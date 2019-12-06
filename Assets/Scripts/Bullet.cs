//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Bullet.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;

/// <summary>Bullet to shot a enemy or the player.</summary>
public class Bullet : MonoBehaviour
{
    /// <summary>The target</summary>
    private Transform target = null;

    /// <summary>The direction</summary>
    private Vector3 direction = Vector3.zero;

    /// <summary>The speed</summary>
    private float speed = 20f;

    /// <summary>Called when [trigger enter].</summary>
    /// <param name="obj">The object.</param>
    public void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Player"))
        {
            obj.GetComponent<Health>().TakeHealth(10);
            GameObject.FindGameObjectWithTag("Damage").GetComponent<AudioSource>().Play();
            MonoBehaviour.Destroy(this.gameObject);
        }

        if (!obj.CompareTag("Player") && !obj.CompareTag("Enemy"))
        {
            MonoBehaviour.Destroy(this.gameObject);
        }
    }

    /// <summary>Sets the target.</summary>
    /// <param name="target">The target.</param>
    public void SetTarget(Transform target) 
    {
        this.target = target;
        if (this.direction == Vector3.zero) 
        {
            this.direction = target.position;
        }
    }

    /// <summary>Updates this instance.</summary>
    private void Update()
    {
        if (this.target != null)
        {
            if (Vector3.Distance(this.transform.position, this.direction) > 0)
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, this.direction, this.speed * Time.deltaTime);
            }
            else
            {
                MonoBehaviour.Destroy(this.gameObject);
            } 
        }
    }
}
