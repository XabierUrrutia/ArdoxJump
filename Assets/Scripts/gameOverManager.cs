using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverManager : MonoBehaviour
{
    public void RetryGameOver()
    {
        SceneManager.LoadScene(1);
    }
}
