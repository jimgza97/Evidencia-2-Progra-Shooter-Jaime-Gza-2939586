using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {

	void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Music");      //busca los objetos que tengan la tag Music
        if (objects.Length > 1)                                                 //si hay mas de 1, destruye 1
            Destroy(this.gameObject);               

        DontDestroyOnLoad(this.gameObject);                                     //El objeto persiste a traves de las escenas
    }
}
