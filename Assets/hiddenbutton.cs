using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class hiddenbutton : MonoBehaviour
{
    [SerializeField] TMP_Text quest;
    public void OnSelected(SelectEnterEventArgs args)
    {
        quest.text = "O";
    }
    // Start is called before the first frame update
    void Start()
    {
        quest.text = "X";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
