using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesManager : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject jstick;

    public int resCorrectas = 0;
    public int nivel = 0;

    private bool onGame = false;
    private GameObject instance;
    private List<GameObject> minigames = new List<GameObject>();
    private List<GameObject> usedMinigames = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {

        Object[] temporalList = Resources.LoadAll("Minigames/Trivia_Convencional", typeof(GameObject));

        for (int i = 0; i < temporalList.Length; i++)
        {
            minigames.Add(temporalList[i] as GameObject);
        }

        minigames = randomList(minigames);

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

        if (resCorrectas >= 10)
        {
            nivel += 1;
            resCorrectas = 0;
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

    public int getCorrectAnsw() {
        return resCorrectas;
    }

    public int getLevel()
    {
        return nivel;
    }

    public void setCorrectAnsw(int x)
    {
        resCorrectas = x;
    }
}
