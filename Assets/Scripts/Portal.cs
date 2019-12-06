//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Portal.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;

/// <summary>Change position player in the map.</summary>
public class Portal : MonoBehaviour
{
    /// <summary>The objective</summary>
    [SerializeField]
    private GameObject objective = null;

    /// <summary>Called when [collision enter].</summary>
    /// <param name="obj">The object.</param>
    public void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.CompareTag("Player"))
        {
            obj.gameObject.transform.position = this.objective.transform.position;
        }
    }
}
