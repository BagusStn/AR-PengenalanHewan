using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    public GameObject ini, itu;
    
    public void Aktifkan()
    {
        ini.SetActive(false);
        itu.SetActive(true);
    }
}
