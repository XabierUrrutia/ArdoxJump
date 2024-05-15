using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offSet;
    public float speed;
    public float fixedHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 desiredPosition = new Vector3(player.position.x + offSet.x, fixedHeight, player.position.z + offSet.z);
        Vector3 targetPos = player.position + offSet;

        transform.position = Vector3.Lerp(transform.position, targetPos, speed);
    }
}
