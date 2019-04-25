using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QR : MonoBehaviour{

	public QRController e_qrcontroller;
	string dataText = "";

    // Start is called before the first frame update
    void Start(){
        e_qrcontroller.e_QRScanFinished += Scann_Finisher;

    }

    // Update is called once per frame
    void Update(){

    }

		void OnGUI(){
			if (GUI.Button (new Rect (0,0, Screen.width, (Screen.height/10), "Reset"))){
				Reset();
			}
			GUI.Box (new Rect (0, Screen.height/10, Sreen.width. Screen.height/10), "");
			GUI.Label (new Rect(0, Screen.height/10, Screen.width, Screen.height/10), dataText);
		}
		// Funcion para terminar el scanner
    void Scann_Finisher(string str){
			dataText = str;

    }

		// Funcion para resetera
		void Reset(){

		}
}
