//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Toten.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>Control the main button of the game</summary>
public class GoToMenu : MonoBehaviour
{
    public void GoToMenuNow() 
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}
