using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnedFeatures : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0,-0.2f,0));
        Destroy(gameObject, 5f);
    }

}
