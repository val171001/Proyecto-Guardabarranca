using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    private Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ani.SetBool("ChangeRight", false);
        ani.SetBool("ChangeLeft", false);
    }

    public void ChangeRight()
    {
        ani.SetBool("ChangeRight", true);
        ani.SetBool("ChangeLeft", false);
    }

    public void ChangeLeft()
    {
        ani.SetBool("ChangeLeft", true);
        ani.SetBool("ChangeRight", false);
    }

    public void ChangeLevel(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
