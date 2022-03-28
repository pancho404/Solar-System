using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += transform.forward * -speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += transform.right * -speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }
}
