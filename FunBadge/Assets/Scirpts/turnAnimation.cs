using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnAnimation : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        if((Input.touchCount > 0 || Input.GetKeyDown("1")) && (anim.GetCurrentAnimatorStateInfo(0).IsName("None"))){
            anim.Play("turn");
        }
    }
}
