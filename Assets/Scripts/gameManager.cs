using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject cylinder;
    public int numberRings;
    public float maxDistance = 5;
    float yPosition;
    // Start is called before the first frame update
    private void Start()
    {
        float yPostion = transform.position.y;
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
}
