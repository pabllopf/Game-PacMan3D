//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Coin.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;

/// <summary>Coin to take and win the game.</summary>
public class Coin : MonoBehaviour
{
    /// <summary>Called when [trigger enter].</summary>
    /// <param name="obj">The object.</param>
    public void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>().Play();
            obj.GetComponent<Wallet>().TakeCoin();
            MonoBehaviour.Destroy(this.gameObject);
        }
    }
}
