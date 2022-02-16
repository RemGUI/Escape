using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene(0);
    }
    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
    public void Defeat()
    {
        SceneManager.LoadScene(2);
    }
    public void Victory()
    {
        SceneManager.LoadScene(3);
    }
}
