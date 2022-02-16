using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenButton : MonoBehaviour
{
    public GameObject plat;
    public void OnClick()
    {
        Destroy(plat);
    }
}
