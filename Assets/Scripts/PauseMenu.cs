//-------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="PauseMenu.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//-------------------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>Pause menu of the game.</summary>
public class PauseMenu : MonoBehaviour
{
    public GameObject menu;

    private void Start()
    {
        menu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !menu.activeSelf)
        {
            menu.SetActive(true);
            Time.timeScale = 0;
            return;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && menu.activeSelf)
        {
            menu.SetActive(false);
            Time.timeScale = 1;
            return;
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
