using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // variables publicas
    public GameObject player;
    public GameObject canvas1;
    public float speed;

    // variables privadas
    private bool movement = true;

    // Start() (first method called)
    void Start()
    {

    }

    // Update() (method called once per frame)
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


    }

    /* OnDisable()
     * Metodo llamado cuando se desactiva el objeto al cual esta
     * puesto este script, permitiendo cambiar la posicion del objeto
     * a 0,0 cuando se desactiva.
     */
    private void OnDisable()
    {
        // cambio de posicion a (0,0)
        transform.localPosition = new Vector3(0f, 0f);
    }

}
