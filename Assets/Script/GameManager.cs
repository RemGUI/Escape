using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    //Trouver Boutton cacher
    //Ouvrir le coffre
    //Résoudre l'enigme des cubes et entrer le code
    public void GameClear()//win
    {
        StartCoroutine(LoadGameClear());
    }
    IEnumerator LoadGameClear()
    {
        yield return new WaitForSeconds(1f);//attente 1s avant de charger win
        SceneManager.LoadScene(3);
    }

    public void GameOver()//win
    {
        StartCoroutine(LoadGameOver());
    }
    IEnumerator LoadGameOver()
    {
        yield return new WaitForSeconds(1f);//attente 1s avant de charger win
        SceneManager.LoadScene(2);
    }

    void Update()
    {
    }
}
