//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Wallet.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;

/// <summary>Control the limit of coins of the player.</summary>
public class Wallet : MonoBehaviour
{
    private int coins = 0;
    public int limitToWin = 10;
    public GameObject gameover;
    public GameObject win;
    public GameObject soundtrack;

    private void Start()
    {
        gameover.SetActive(false);
        win.SetActive(false);
    }

    public void TakeCoin()
    {
        this.coins++;
        if (this.coins >= this.limitToWin) 
        {
            win.SetActive(true);
            Destroy(soundtrack);
            Time.timeScale = 0;
            Destroy(this.gameObject);
        }
    }

    public void SpendCoin()
    {
        this.coins--;
        if (coins <= 0) 
        {
            gameover.SetActive(true);
            Destroy(soundtrack);
            Time.timeScale = 0;
            Destroy(this.gameObject);
        }
    }
}
