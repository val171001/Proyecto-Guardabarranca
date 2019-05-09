using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesAnsManager : MonoBehaviour
{

    public void correctAnswer()
    {
        Debug.Log("Correct");
        Destroy(gameObject);
    }

    public void incorrectAnswer()
    {
        Debug.Log("Incorrect");
        Destroy(gameObject);
    }
}
