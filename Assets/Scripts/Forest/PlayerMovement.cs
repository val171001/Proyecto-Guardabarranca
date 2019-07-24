using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public GameObject canvas1;
    public float speed;

    private bool movement = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movement)
        {
            // Gets location of joystick
            float h = transform.localPosition.x / 50;
            float v = transform.localPosition.y / 50;

            // Transorms position and rotation
            player.transform.position += player.transform.forward * speed * v * Time.deltaTime;
            player.transform.Rotate(new Vector3(0, h * Time.timeScale, 0));
        }

        if (canvas1.activeSelf == false)
        {

        }

    }

}
