using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosCtr : MonoBehaviour
{

    public TextMeshProUGUI name;
    public TextMeshProUGUI level;
    public TextMeshProUGUI points;

    public GameObject player;

    private void Start()
    {
        name.text = name.text + " default";
        level.text = level.text + " " + player.GetComponent<MiniGamesManager>().getLevel();
        points.text = points.text + " " + player.GetComponent<MiniGamesManager>().getCorrectAnsw();
    }

    public void exit()
    {
        Destroy(gameObject);
    }
}
