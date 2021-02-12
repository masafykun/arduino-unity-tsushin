using UnityEngine;

public class ChangeColorOnHit : MonoBehaviour {

	GameObject Serial;
	SerialReadLeft script;

	void Start () {
		Serial = GameObject.Find ("SerialCom");
		script = Serial.GetComponent<SerialReadLeft>();
	}

	public void LED_ON2(){
		byte[] byte1 = new byte[1];
		byte1 [0] = 66; 
		script.Port2.Write (byte1, 0, 1);
	}

	public void LED_OFF2(){
		byte[] byte1 = new byte[1];
		byte1 [0] = 11;
		script.Port2.Write (byte1, 0, 1);
	}

	void OnCollisionEnter(Collision collision) {
		LED_ON2 ();
	}

	void OnCollisionExit(Collision collision){
		LED_OFF2 ();
	}
}