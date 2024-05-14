using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicioManager : MonoBehaviour
{
    public void StartGame()
    {
        // Asumiendo que el índice de la escena del juego es 0
        SceneManager.LoadScene(1);
    }
}
