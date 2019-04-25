using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesManager : MonoBehaviour
{

    public GameObject cover;
    public Camera cam;

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
    /*s
    private void OnCollisionEnter(Collision collision)
 
    {
        if (!done)
        {
            cover.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y - 0.75f,
                cam.transform.position.z + 0.25f);

            done = true;
        }
    
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        if (!done)
        {
            cover.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y - 0.75f,
                cam.transform.position.z + 0.25f);

            done = true;
        }
    }
}
