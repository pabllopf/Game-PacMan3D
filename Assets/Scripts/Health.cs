//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Health.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI;

/// <summary>Health of a player or a enemy.</summary>
public class Health : MonoBehaviour
{
    public bool player;
    public GameObject gameover = null;
    public int health = 100;
    public GameObject soundtrack;

    private void Start()
    {
        if (player) 
        {
            gameover.SetActive(false);
        } 
    }

    public void TakeHealth(int amount) 
    {
        if (player) 
        {
            if (health <= 0) 
            {
                gameover.SetActive(true);
                Destroy(soundtrack);
                Time.timeScale = 0;
                Destroy(this.gameObject);
            }
            GameObject.FindGameObjectWithTag("Scroll").GetComponent<Scrollbar>().size -=  (amount / 100f);
        }
        health -= amount;
    }

    public void GiveHealth(int amount)
    {
        if (player)
        {
            if ((health + amount) < 100 && health > 0)
            {
                health += amount;
                GameObject.FindGameObjectWithTag("Scroll").GetComponent<Scrollbar>().size += (amount / 100f);
            }
        }
    }

}
