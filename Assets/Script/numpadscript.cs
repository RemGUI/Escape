using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class numpadscript : MonoBehaviour
{
    [SerializeField] TMP_Text screen;
    [SerializeField] TMP_Text quest;
    private int temp = 10;
    private int i = 0;
    private int[] code = new int[4];
    private Animator animator;
    public GameObject door;

    public void OnClick(int number)
    {
        temp = number;
        Debug.Log(number);
    }
    private void erase()
    {
        for (i = 0; i < 4; i++)
        {
            code[i] = 10;
            temp = 10;
        }
        i = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        erase();
        animator = door.GetComponent<Animator>();
        quest.text = "X";
    }

    // Update is called once per frame
    void Update()
    {
        affichecode();
        if(temp == 12)
        {
            erase();
        }
        if(temp == 11)
        {
            if(code[0]== 1 && code[1]== 8 && code[2]== 1 && code[3]== 3)
            {
                //Debug.Log("ok");
                animator.SetTrigger("dooropen");
                quest.text = "O";
                GameManager.instance.GameClear();
            }
            else
            {
                erase();
            }
        }
        if(temp != 10 && i < 4)
        {
            code[i] = temp;
            i++;
            temp = 10;
        }
    }
    public void affichecode()
    {
        if(code[0] == 10)
        { 
            screen.text = "X" + " " + "X" + " " + "X" + " " + "X";
        }
        else if(code[1] == 10)
        {
            screen.text = code[0].ToString() + " " + "X" + " " + "X" + " " + "X";
        }
        else if (code[2] == 10)
        {
            screen.text = code[0].ToString() + " " + code[1].ToString() + " " + "X" + " " + "X";
        }
        else if (code[3] == 10)
        {
            screen.text = code[0].ToString() + " " + code[1].ToString() + " " + code[2].ToString() + " " + "X";
        }
        else
        { 
            screen.text = code[0].ToString() + " " + code[1].ToString() + " " + code[2].ToString() + " " + code[3].ToString();
        }
    }
    void GameClear()//win
    {
        StartCoroutine(LoadGameClear());
    }
    IEnumerator LoadGameClear()
    {
        yield return new WaitForSeconds(2f);//attente 1s avant de charger win
        SceneManager.LoadScene(3);
    }
}
