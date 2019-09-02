using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour {
    public GameObject column;
    public float spawnTime;
    public float elapseTime;
	// Use this for initialization
	void Start () {
        /*Incializamos los atributos*/
        spawnTime = 4f;
        elapseTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if(GameController.instance.gameOver == false)
        {
            /*Condicion para detectar el elapseTime*/
            if (elapseTime < spawnTime)
            {
                elapseTime += Time.deltaTime;
            }
            else
            {
                /*Si es mayor a 0 se agregara una columna*/
                float random = Random.Range(-2f, 2f);
                Instantiate(column, new Vector3(8, random, 0), Quaternion.identity);
                elapseTime = 0;
            }
        }
	}
}
