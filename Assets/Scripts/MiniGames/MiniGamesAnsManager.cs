using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGamesAnsManager : MonoBehaviour
{
    private float timer;
    private float time_game;
    private bool countIt = false;

    private Animator ani;
    private Image img_timer;
    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
        img_timer = transform.GetChild(9).gameObject.GetComponent<Image>();
        ani = GetComponent<Animator>();
    }

    public void correctAnswer()
    {
        int beforeAnsw = player.GetComponent<MiniGamesManager>().getCorrectAnsw();
        player.GetComponent<MiniGamesManager>().setCorrectAnsw(beforeAnsw + 1);

        ani.SetBool("correcto", true);
        countIt = true;
    }

    public void incorrectAnswer()
    {
        ani.SetBool("incorrecto", true);
        countIt = true;
    }

    private void Update()
    {
        time_game += Time.deltaTime;
        img_timer.fillAmount = 1 - time_game/20f;

        if (img_timer.fillAmount <= 0)
        {
            ani.SetBool("tiempo", true);
            countIt = true;
        }
            

        if (countIt)
        {
            timer += Time.deltaTime;
        }

        if (timer > 2f)
        {
            Destroy(gameObject);
        }
    }
}
