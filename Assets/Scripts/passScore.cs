using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passScore : MonoBehaviour
{
    public GameObject particle;

    public void OnTriggerEnter(Collider other)
    {
        gameManager.singleton.AddScore(1);
        FindObjectOfType<ballMovement>().numBounce = 3;
        FindObjectOfType<ballMovement>().pass++;
        Vector3 vector = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z - 0.5f);
        Instantiate(particle, vector, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
