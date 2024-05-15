using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passScore : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        gameManager.singleton.AddScore(1);
        FindObjectOfType<ballMovement>().pass++;
    }
}
