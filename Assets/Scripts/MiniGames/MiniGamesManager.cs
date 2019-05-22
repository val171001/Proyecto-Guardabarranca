using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesManager : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject jstick;
    public GameObject mg_example;
    public GameObject mg_1;

    private bool onGame;
    private GameObject instance;
    private List<GameObject> minigames = new List<GameObject>();
    private List<GameObject> usedMinigames = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        minigames.Add(mg_example);
        minigames.Add(mg_1);

        onGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (onGame)
        {
            if (!instance)
            {
                canvas1.SetActive(true);
                jstick.SetActive(true);
                onGame = false;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("MiniGame"))
        {
            canvas1.SetActive(false);
            jstick.SetActive(false);
            Destroy(other.gameObject);
            instance = Instantiate(minigames[0]);
            usedMinigames.Add(minigames[0]);
            minigames.RemoveAt(0);
            onGame = true;

            if (minigames.Count == 0)
            {
                for (int i = 0; i < usedMinigames.Count; i++)
                {
                    minigames.Add(usedMinigames[i]);
                }
                usedMinigames.Clear();
            }

        }
 
    }
}
