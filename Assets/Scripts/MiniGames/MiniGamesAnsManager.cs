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

    public void correctAnswer()
    {
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
