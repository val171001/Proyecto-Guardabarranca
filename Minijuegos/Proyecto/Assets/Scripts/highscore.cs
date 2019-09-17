

// Importamos librerias necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour {

    public Text score;
    
	// Use this for initialization
	void Start () {
        // Cargamos el highscore
        score.text = "HigShcore: " + PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
