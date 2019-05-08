using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesManager : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject mg_example;

    private bool done;
    
    // Start is called before the first frame update
    void Start()
    {
        done = false;
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("MiniGame"))
        {
            canvas1.SetActive(false);
            Instantiate(mg_example);
            Destroy(other);
        }
 
    }
}
