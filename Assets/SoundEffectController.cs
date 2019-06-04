using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectController : MonoBehaviour {
    private AudioSource soundEffect;
    
	// Use this for initialization
	void Start () {
        soundEffect = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "CubeTug" || other.gameObject.tag == "GroundTug")
        {
            this.soundEffect.Play();
            
        }
    }
}
