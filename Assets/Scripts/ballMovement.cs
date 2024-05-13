using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody.velocity = new Vector3(0, speed, 0) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) 
    {
        rigidbody.velocity = new Vector3(0, speed, 0) * Time.deltaTime;
    }
}
