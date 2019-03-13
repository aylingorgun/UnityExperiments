using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbButton : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;
  
    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("VirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
       
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       
        Debug.Log("Button released");
    }
}

