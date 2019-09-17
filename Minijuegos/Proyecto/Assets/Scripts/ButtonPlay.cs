

// Importamos clases necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonPlay : MonoBehaviour
{

    // Funcion a ejecutar al presionar el boton
    public void onClick()
    {
        // Cargamos la escena del juego
        SceneManager.LoadScene("Level 1");
    }
}
