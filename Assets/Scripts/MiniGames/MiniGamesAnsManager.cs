using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesAnsManager : MonoBehaviour
{
    private float Timer;
    private bool countIt = false;
    private GameObject showing;

    public GameObject correct;
    public GameObject incorrect;
    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    public void correctAnswer()
    {
        int beforeAnsw = player.GetComponent<MiniGamesManager>().getCorrectAnsw();
        player.GetComponent<MiniGamesManager>().setCorrectAnsw(beforeAnsw + 1);

        showing = Instantiate(correct);
        countIt = true;
    }

    public void incorrectAnswer()
    {
        showing = Instantiate(incorrect);
        countIt = true;
    }

    private void Update()
    {
        if (countIt)
        {
            Timer += Time.deltaTime;
        }

        if (Timer > 2.5f)
        {
            Destroy(showing);
            Destroy(gameObject);
        }
    }
}
