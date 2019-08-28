using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
    private float scrollingSpeed;

	// Use this for initialization
	void Start () {
        /*Inicializamos el atributo*/
        scrollingSpeed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        if(GameController.instance.gameOver == false)
        {
            /*Funcion para que el Blackground se mueva*/
            transform.Translate(Vector3.left * scrollingSpeed * Time.deltaTime);
            /*Funcion que sirve para que se repita el blackground*/
            if (transform.position.x < -20.4f)
            {
                transform.position = new Vector3(20.4f, transform.position.y, transform.position.z);
            }
        }
	}
}
