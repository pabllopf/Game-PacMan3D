//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Toten.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;

/// <summary>Give health to the player.</summary>
public class Toten : MonoBehaviour
{
    /// <summary>Called when [trigger enter].</summary>
    /// <param name="obj">The object.</param>
    public void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Player")) 
        {
            obj.GetComponent<Health>().GiveHealth(10);
            MonoBehaviour.Destroy(this.gameObject);
        }
    }
}
