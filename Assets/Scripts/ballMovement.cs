using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody rigidbody;
    public GameObject splash;

    private void OnCollisionEnter(Collision collision) 
    {
        rigidbody.velocity = new Vector3(0, speed, 0) ;

        GameObject newSplash = Instantiate(splash
        ,new Vector3(transform.position.x, collision.transform.position.y + 0.14f, transform.position.z), 
        splash.transform.rotation) as GameObject;

        newSplash.transform.parent = collision.transform;

        Destroy(newSplash, 0.5f);

        if(collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("ArdoxJump");
            Destroy(this.gameObject);
        }
    }
}
