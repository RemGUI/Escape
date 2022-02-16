using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class chestannimation : MonoBehaviour
{
    [SerializeField] TMP_Text quest;
    private Animator animatorkey;
    private Animator animatorchest;
    public GameObject key;
    public GameObject openchest;

    public void OnSelect(SelectEnterEventArgs args)
    {
        animatorkey.SetTrigger("keyinchest");
        animatorchest.SetTrigger("openchest");
        quest.text = "O";
    }
    // Start is called before the first frame update
    void Start()
    {
        animatorkey = key.GetComponent<Animator>();
        animatorchest = openchest.GetComponent<Animator>();
        quest.text = "X";
    }

    // Update is called once per frame
    void Update()
    {

    }
}