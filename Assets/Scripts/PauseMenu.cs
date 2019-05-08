using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject panel1;
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
}
