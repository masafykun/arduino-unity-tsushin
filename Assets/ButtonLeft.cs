using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ButtonLeft : MonoBehaviour {

	GameObject Serial;
	SerialReadLeft script;

	// Use this for initialization
	void Start () {
		Serial = GameObject.Find ("SerialCom");
		script = Serial.GetComponent<SerialReadLeft>();
	}



	//親指↓
	public void Oyayubi_1_ON(){
		script.Arduino_Send (121);
		Debug.Log ("親指第一関節ON\n121");
	}
	public void Oyayubi_2_ON(){
		script.Arduino_Send (122);
		Debug.Log ("親指第二関節ON\n122");
	}
	public void Oyayubi_1_OFF(){
		script.Arduino_Send (021);
		Debug.Log ("親指第一関節OFF\n021");
	}
	public void Oyayubi_2_OFF(){
		script.Arduino_Send (022);
		Debug.Log("親指第二関節OFF\n022");
	}
	//親指↑

	//人差し指↓
	public void Hitosasiyubi_3_ON(){
		script.Arduino_Send (123);
		Debug.Log("人差し指第一関節ON\n123");
	}
	public void Hitosasiyubi_3_OFF(){
		script.Arduino_Send (023);
		Debug.Log("人差し指第一関節OFF\n023");
	}
	//人差し指↑

	//中指↓
	public void Nakayubi_6_ON(){
		script.Arduino_Send (126);
		Debug.Log("中指第一関節ON\n126");
	}
	public void Nakayubi_6_OFF(){
		script.Arduino_Send (026);
		Debug.Log("中指第一関節OFF\n026");
	}
	//中指↑

	//薬指↓
	public void Kusuriyubi_9_ON(){
		script.Arduino_Send (129);
		Debug.Log("薬指第一関節ON\n129");
	}
	public void Kusuriyubi_9_OFF(){
		script.Arduino_Send (029);
		Debug.Log("薬指第一関節OFF\n029");
	}
	//薬指↑

	//小指↓
	public void Koyubi_12_ON(){
		script.Arduino_Send (132);
		Debug.Log("小指第一関節ON\n132");
	}
	public void Koyubi_12_OFF(){
		script.Arduino_Send (032);
		Debug.Log("小指第一関節OFF\n032");
	}
	//小指↑






	public void OnLED_R123(){
		script.Arduino_Send (123); 
		Debug.Log ("LedOn_R123");
	}

	public void OffLED_R023(){
		script.Arduino_Send (023);
		Debug.Log ("LedOff_R023");
	}

	public void OnLED_test(){
		script.LED_ON2 ();
		Debug.Log ("LedOn_test");
	}


	/*
		public void LED_ON(){
			byte[] byte1 = new byte[1];
			byte1 [0] = 66; 
			script.Port1.Write (byte1, 0, 1);
		}
		public void LED_OFF(){
			byte[] byte1 = new byte[1];
			byte1 [0] = 00;
			script.Port1.Write (byte1, 0, 1);
		}

		public void LED_ON2(){
			byte[] byte1 = new byte[1];
			byte1 [0] = 55; 
			script.Port1.Write (byte1, 0, 1);
		}
		public void LED_OFF2(){
			byte[] byte1 = new byte[1];
			byte1 [0] = 11;
			script.Port1.Write (byte1, 0, 1);
		}	
		*/

}

