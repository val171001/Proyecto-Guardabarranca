using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesManager : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject mg_example;

    private bool onGame;
    private GameObject instance;
    
    // Start is called before the first frame update
    void Start()
    {
        onGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (onGame)
        {
            if (!instance)
            {
                canvas1.SetActive(true);
                onGame = false;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("MiniGame"))
        {
            canvas1.SetActive(false);
            Destroy(other.gameObject);
            instance = Instantiate(mg_example);
            onGame = true;
        }
 
    }
}
