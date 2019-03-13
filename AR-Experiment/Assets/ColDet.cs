using UnityEngine;
using System.Collections;

public class ColDet : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
        }
    }
}