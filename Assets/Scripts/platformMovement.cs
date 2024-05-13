using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
   
    private void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.rotation *= Quaternion.Euler(new Vector3(0, 2f, 0));
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.rotation *= Quaternion.Euler(new Vector3(0, -2f, 0));
        }
    }
}
