using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private float speed = 10f;

    private float turnSpeed = 200f;

    void Update()
    {
        if(Interactions.isActive) return;
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -(speed / 2) * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, - turnSpeed * Time.deltaTime, 0);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }
    }
}
