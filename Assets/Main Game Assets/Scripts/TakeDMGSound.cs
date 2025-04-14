using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDMGSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AudioSource shootSound = GetComponent<AudioSource>();
        shootSound.Play();
    }
}
