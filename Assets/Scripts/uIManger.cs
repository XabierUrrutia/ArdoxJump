using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uIManger : MonoBehaviour
{
    public Text currentScoreText;
    public Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentScoreText.text = "Score: " + gameManager.singleton.currentScore;
        bestScoreText.text = "Best: " + gameManager.singleton.bestScore;
    }
}
