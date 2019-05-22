using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesManager : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject jstick;

    public GameObject mg_1;
    public GameObject mg_2;
    public GameObject mg_3;
    public GameObject mg_4;
    public GameObject mg_5;
    public GameObject mg_6;
    public GameObject mg_7;
    public GameObject mg_8;
    public GameObject mg_9;
    public GameObject mg_10;
    
    private bool onGame;
    private GameObject instance;
    private List<GameObject> temporalList = new List<GameObject>();
    private List<GameObject> minigames = new List<GameObject>();
    private List<GameObject> usedMinigames = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        temporalList.Add(mg_1);
        temporalList.Add(mg_2);
        temporalList.Add(mg_3);
        temporalList.Add(mg_4);
        temporalList.Add(mg_5);
        temporalList.Add(mg_6);
        temporalList.Add(mg_7);
        temporalList.Add(mg_8);
        temporalList.Add(mg_9);
        temporalList.Add(mg_10);

        minigames = randomList(temporalList);

        onGame = false;
    }

    List<GameObject> randomList(List<GameObject> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            GameObject temp = lista[i];
            int randomIndex = Random.Range(i, lista.Count);
            lista[i] = lista[randomIndex];
            lista[randomIndex] = temp;
        }

        return lista;
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
