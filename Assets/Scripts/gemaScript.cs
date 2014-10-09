using UnityEngine;
using System.Collections;

public class gemaScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void update () {
		}

	void OnTriggerEnter2D (Collider2D other) {
		if(other.transform.tag=="Player") 
				Application.LoadLevel ("nivel02");
		}
	
}
