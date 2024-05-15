using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballMovement : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody rigidbody;
    public GameObject splash;

    [HideInInspector]
    public int pass;
    public float superSpeed = 10f;
    private bool isSuperSpeedActive;
    private int perfectPassCount = 2;
    

    void Start()
    {
        
        if (rigidbody == null)
        {
            rigidbody = GetComponent<Rigidbody>();
        }
    }

    private void Update()
    {
        if (pass > perfectPassCount )
        {
            isSuperSpeedActive = true;
        }
    }

    private void OnCollisionEnter(Collision collision) 
    {
        Time.timeScale = 0.5f;
        rigidbody.velocity = new Vector3(0, speed*2, 0)* Time.timeScale;
        
        GameObject newSplash = Instantiate(splash, new Vector3(transform.position.x, collision.transform.position.y + 0.14f, transform.position.z), 
        splash.transform.rotation) as GameObject;

        newSplash.transform.parent = collision.transform;
        
        Destroy(newSplash, 0.5f);

        if (isSuperSpeedActive)
        {
            Destroy(collision.transform.parent.gameObject, 0.2f);
        }
        else
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene(2);
            }
        }
        pass = 0;
        isSuperSpeedActive = false;
    }



}
