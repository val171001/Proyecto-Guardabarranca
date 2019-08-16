using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGamesAnsManager : MonoBehaviour
{
    // Variables privadas
    private float timer;
    private float time_game;
    private bool countIt = false;

    // Objetos privados
    private Animator ani;
    private Image img_timer;
    private GameObject player;

    /* Start() (first method called)
     * Se inicializan los objetos privados.
     */
    private void Start()
    {
        player = GameObject.Find("Player");
        img_timer = transform.GetChild(9).gameObject.GetComponent<Image>();
        ani = GetComponent<Animator>();
    }

    /* correctAnswer() PUBLIC
     * Metodo utilizado para cambiar la puntuacion del jugador e inicializar
     * animacion de respuesta correcta.
     */
    public void correctAnswer()
    {
        // cambio de puntuacion
        int beforeAnsw = player.GetComponent<MiniGamesManager>().getCorrectAnsw();
        player.GetComponent<MiniGamesManager>().setCorrectAnsw(beforeAnsw + 1);

        // cambio animacion
        ani.SetBool("correcto", true);
        countIt = true;
    }

    /* correctAnswer() PUBLIC
     * Metodo utilizado para cambiar la animacion a una de respuesta incorrecta.
     */
    public void incorrectAnswer()
    {
        // cambio de animacion
        ani.SetBool("incorrecto", true);
        countIt = true;
    }

    /* Update() (method called every frame)
     * Se realizan los cambios necesarios por frame.
     */
    private void Update()
    {
        time_game += Time.deltaTime;                // tiempo desde que empezo el minijuego 
        img_timer.fillAmount = 1 - time_game/20f;   // representacion de tiempo restante en imagen

        // si el tiempo se la acaba al jugador.
        if (img_timer.fillAmount <= 0)
        {
            ani.SetBool("tiempo", true);
            countIt = true;
        }
            
        // se activa luego de que el jugador responda o se le acabe el tiempo.
        if (countIt)
        {
            timer += Time.deltaTime;
        }

        // se utiliza para para destruir el objeto luego de segundos que el jugador habra respondido.
        if (timer > 2f)
        {
            Destroy(gameObject);
        }
    }
}
