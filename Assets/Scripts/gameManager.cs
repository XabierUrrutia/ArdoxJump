using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject cylinder;
    public int numberRings = 30;
    public float maxDistance = 5;
    float yPosition;
    private bool gameOver = false;
   
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
        if(!gameOver)
        {
            gameOver = true;
            SceneManager.LoadScene(1);
        }
        
    }
}
