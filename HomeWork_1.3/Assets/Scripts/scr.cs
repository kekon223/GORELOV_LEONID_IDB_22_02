using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr : MonoBehaviour
{
    public GameObject TestObj;



    public void Deactive()
    {
        TestObj.SetActive(false);
    }

    public void Activate()
    {
        TestObj.SetActive(true);
    }
}
