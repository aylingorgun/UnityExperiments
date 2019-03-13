using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    Animator animatorrr;
    // Use this for initialization

    void Start()
    {
        animatorrr = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            animatorrr.SetTrigger("pro");
        }
    }
}
