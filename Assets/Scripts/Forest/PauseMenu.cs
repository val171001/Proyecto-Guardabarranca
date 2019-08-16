using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // variables publicas
    public GameObject canvas1;
    public GameObject panel1;
    public GameObject puntos;
    public GameObject galeria;
    public Button btn1;

    // variables privadas
    private bool pauseOn = false;

    // Start() (first method called)
    void Start()
    {
        // se agrega listener al boton de pausa
        btn1.onClick.AddListener(pause);
    }

    /* pause()
     * Cambia los canvas activados segun se este en pausa o no,
     * ademas se cambia el timesScale si esta en pausa para 
     * evitar movimientos en la escena.
     */
    void pause()
    {
        if (pauseOn)
        {
            // cambios de canvas
            canvas1.SetActive(true);
            panel1.SetActive(false);

            // cambio timescale y pauseON
            Time.timeScale = 1;
            pauseOn = false;
        }
        else
        {
            // cambios de canvas
            canvas1.SetActive(false);
            panel1.SetActive(true);

            // cambio timescale y pauseON
            Time.timeScale = 0;
            pauseOn = true;
        }

    }

    /* continuar()
     * Desactiva la pausa, es un metodo publico para que pueda
     * ser accesado por otros componentes de la escena.
     */
    public void continuar()
    {
        pause();
    }

    /* gal()
     * Crea la galeria, es un metodo publico para que pueda
     * ser accesado por otros componentes de la escena.
     */
    public void gal()
    {
        Instantiate(galeria);
    }

    /* gal()
     * Crea la instancia de puntos, es un metodo publico para que pueda
     * ser accesado por otros componentes de la escena.
     */
    public void puntuaciones()
    {
        GameObject inst =  Instantiate(puntos);
        inst.SetActive(true);
    }

    /* returnToMenu()
     * Se regresa al menu principal, es un metodo publico para que pueda
     * ser accesado por otros componentes de la escena.
     */
    public void returnToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
