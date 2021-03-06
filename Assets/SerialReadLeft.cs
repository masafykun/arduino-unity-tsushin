using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class SerialReadLeft : MonoBehaviour {

	public SerialPort Port2 = new SerialPort("COM7",9600); //COM3のところはそれぞれ確認して。
	void Start () {

		if (Port2.IsOpen) {
			Port2.Close ();
		} else {
			Port2.Open ();
			Port2.ReadTimeout = 1000;
		}
	}

	void Update () {

		if(Input.GetKey(KeyCode.N)){
			Debug.Log ("N");
			byte[] byte1 = new byte[1]; //byte1は1byteを入れれるようにする。
			byte1 [0] = 66; //byte1の0番目に66を挿入
			Port2.Write(byte1,0,1);
		}
		if (Input.GetKey (KeyCode.M)) {
			Debug.Log ("M");
			byte[] byte1 = new byte[1];
			byte1 [0] = 00;
			Port2.Write (byte1, 0, 1);
		}
	}

	//重要！！
	public void Arduino_Send(byte n){    //Arduino側にbyte値を送信
		byte[] byte1 = new byte[1];
		byte1 [0] = n; 
		Port2.Write (byte1, 0, 1);
		Debug.Log (n);
	}
	//重要！！

	public void LED_OFF(byte n){
		byte[] byte1 = new byte[1];
		byte1 [0] = n;
		Port2.Write (byte1, 0, 1);
		Debug.Log (n);
	}
	public void LED_ON(byte n){
		byte[] byte1 = new byte[1];
		byte1 [0] = n;
		Port2.Write (byte1, 0, 1);
		Debug.Log (n);
	}

	public void LED_ON2(){
		byte[] byte1 = new byte[1];
		byte1 [0] = 66; 
		Port2.Write (byte1, 0, 1);
	}
	public void LED_OFF2(){
		byte[] byte1 = new byte[1];
		byte1 [0] = 11;
		Port2.Write (byte1, 0, 1);
	}



}