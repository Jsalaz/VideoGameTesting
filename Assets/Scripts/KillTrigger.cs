﻿using UnityEngine;
using System.Collections;

public class KillTrigger : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "Player") {
			//Debug.Log ("Player Collider Entered The Trigger");
			PlayerController.instance.Kill();
		}
	}



}
