using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesManager : MonoBehaviour
{
    // Objetos publicos
    public GameObject canvas1;
    public GameObject jstick;

    // Variables publicas
    public int resCorrectas = 0;
    public int nivel = 0;
    private bool onGame = false;

    // Objetos privados
    private GameObject instance;
    private List<GameObject> minigames = new List<GameObject>();
    private List<GameObject> usedMinigames = new List<GameObject>();


    /* Start() (first method called) 
     * Se inicializa la lista de minijuegos a mostrar y se randomiza.
     */
    void Start()
    {
        // Se buscan los minijuegos en la carpeta de Minigames/Trivia_Convencional y se cargan.
        Object[] temporalList = Resources.LoadAll("Minigames/Trivia_Convencional", typeof(GameObject));

        // Se agregan los minijuegos a la lista minigames.
        for (int i = 0; i < temporalList.Length; i++)
        {
            minigames.Add(temporalList[i] as GameObject);
        }

        // Se randomiza la lista.
        minigames = randomList(minigames);

    }

    /* randomList(List<GameObject>)
     * metodo utilizado para randomizar listas y devolver una lista randomizada.
     */
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

    // Update() (Metodo llamado cada frame)
    void Update()
    {
        // si el juego esta prendido
        if (onGame)
        {
            if (!instance)
            {
                canvas1.SetActive(true);
                jstick.SetActive(true);
                onGame = false;
            }
        }

        // cambio de nivel
        if (resCorrectas >= 10)
        {
            nivel += 1;
            resCorrectas = 0;
        }

    }

    /* OnTriggerEnter(Collider)
     * sistema de colisiones para los minigames. Llama un nuevo minigame
     * cada vez que se colisiona con un objeto con tag "Minigame"
     */
    private void OnTriggerEnter(Collider other)
    {
        // condicion que el tag sea "Minigame"
        if (other.tag.Equals("MiniGame"))
        {
            // Se desactivan los canvas de movimiento
            canvas1.SetActive(false);
            jstick.SetActive(false);

            // Se destruye el objeto con el que se coliciono
            Destroy(other.gameObject);

            // Se instancia un nuevo minijuego
            instance = Instantiate(minigames[0]);
            usedMinigames.Add(minigames[0]);

            // Se remueve el minijuego usado y se empieza el juego.
            minigames.RemoveAt(0);
            onGame = true;


            /* En el caso que se quede sin nuevos minijuegos se reutilizan los
             * juegos previos.
             */ 
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

    /* getCorrectAnsw() PUBLIC
     * regresa la cantidad de respuestas correctas.
     */
    public int getCorrectAnsw() {
        return resCorrectas;
    }


    /* getLevel() PUBLIC
     * regresa el nivel del jugador.
     */
    public int getLevel()
    {
        return nivel;
    }

    /* setCorrectAnsw(int) PUBLIC
     * establece la cantidad de respuestas correctas.
     */
    public void setCorrectAnsw(int x)
    {
        resCorrectas = x;
    }
}
