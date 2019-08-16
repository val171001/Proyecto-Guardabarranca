using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /* PlayGame()
     * Se llama por medio de un boton para cambiar
     * a la escena 1.
     */
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    /* QuitGame()
     * Se llama por medio de un boton para cambiar
     * salir de la aplicacion.
     */
    public void QuitGame()
    {
        Application.Quit();
    }
}
