//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="StartMenu.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>Start menu of the game.</summary>
public class StartMenu : MonoBehaviour
{
    public GameObject title;
    public GameObject buttons;
    public GameObject credit;

    private void Start()
    {
        credit.SetActive(false);
    }

    public void StartGame() 
    {
        SceneManager.LoadScene("Game");
    }

    public void Credits() 
    {
        title.SetActive(false);
        buttons.SetActive(false);
        credit.SetActive(true);
    }

    /// <summary>Exits the game.</summary>
    public void ExitGame() 
    {
        Application.Quit();
    }

    public void ReturnMenu() 
    {
        title.SetActive(true);
        buttons.SetActive(true);
        credit.SetActive(false);
    }
}
