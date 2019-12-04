//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Bullet.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;

/// <summary>Bullet to shot a enemy or the player.</summary>
public class Bullet : MonoBehaviour
{
    private Transform target;
    private Vector3 direction;


    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        
    }
}
