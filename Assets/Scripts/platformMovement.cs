using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private void Start()
    {
        speed = 5f;
    }
    private void Update()
    {


        if(Input.GetKey(KeyCode.RightArrow))
        {
            if (gameManager.singleton.currentScore > 20 && gameManager.singleton.currentScore < 50) {
                speed = 2.5f;
            }else if(gameManager.singleton.currentScore > 50) {
                speed = 7.5f;
            }
            this.transform.rotation *= Quaternion.Euler(new Vector3(0, speed, 0));
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameManager.singleton.currentScore > 20 && gameManager.singleton.currentScore < 50) {
                speed = 2.5f;
            }else if(gameManager.singleton.currentScore > 50) {
                speed = 7.5f;
            }
            this.transform.rotation *= Quaternion.Euler(new Vector3(0, -speed, 0));
        }
    }
}
