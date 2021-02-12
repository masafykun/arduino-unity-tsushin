using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyayubi : MonoBehaviour {

	GameObject Serial;
	SerialReadLeft script;

	void Start () {
		Serial = GameObject.Find ("SerialCom");
		script = Serial.GetComponent<SerialReadLeft>();
	}

	void OnCollisionEnter(Collision collision) {
		byte[] byte1 = new byte[1];
		byte1 [0] = 101; 
		script.Port2.Write (byte1, 0, 1);
	}

	void OnCollisionExit(Collision collision){
		byte[] byte1 = new byte[1];
		byte1 [0] = 001; 
		script.Port2.Write (byte1, 0, 1);
	}

}
