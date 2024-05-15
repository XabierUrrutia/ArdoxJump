using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject cylinder;
    public int numberRings = 30;
    public float maxDistance = 5;
    private bool gameOver = false;
    public int bestScore;
    public int currentScore = 0;
    public static gameManager singleton;
    float yPosition;
    
   
    void Awake()
    {
        if(singleton == null)
        {
            singleton = this;
        }
        else if(singleton != this)
        {
            Destroy(gameObject);
        }
        bestScore = PlayerPrefs.GetInt("HighScore");
    }

    private void Start() 
    {
        yPosition = -1.8f;
        for(int i = 0; i< numberRings; i++)
        {
            SpawnRings();
        }
    }

    public void SpawnRings()
    {
        Instantiate(cylinder, new Vector3(transform.position.x, yPosition, transform.position.z), Quaternion.identity);
        yPosition -= maxDistance;
    }

    public void EndGame()
    {
        
        if (!gameOver)
        {
            gameOver = true;
            SceneManager.LoadScene(1);
            
        }
    }

    public void AddScore(int score)
    {
        currentScore += score;

        if(currentScore > bestScore)
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("HighScore", currentScore);
        }
    }   
}
