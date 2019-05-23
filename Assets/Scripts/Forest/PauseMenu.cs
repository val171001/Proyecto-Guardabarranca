using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject panel1;
    public GameObject puntos;
    public GameObject galeria;
    public Button btn1;

    private bool pauseOn = false;

    // Start is called before the first frame update
    void Start()
    {
        btn1.onClick.AddListener(pause);
    }

    // Update is called once per frame
    void pause()
    {
        if (pauseOn)
        {
            canvas1.SetActive(true);
            panel1.SetActive(false);
            Time.timeScale = 1;
            pauseOn = false;
        }
        else
        {
            canvas1.SetActive(false);
            panel1.SetActive(true);
            Time.timeScale = 0;
            pauseOn = true;
        }

    }

    public void continuar()
    {
        pause();
    }

    public void gal()
    {
        Instantiate(galeria);
    }

    public void puntuaciones()
    {
        GameObject inst =  Instantiate(puntos);
        inst.SetActive(true);
    }


    public void returnToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
