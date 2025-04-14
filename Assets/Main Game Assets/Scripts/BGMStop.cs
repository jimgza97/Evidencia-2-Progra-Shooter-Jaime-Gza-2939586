using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMStop : MonoBehaviour {

void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Music");
        for (int i = 0; i < objects.Length; i++)
        {
            Destroy(objects[i]);
        }
    }
}
