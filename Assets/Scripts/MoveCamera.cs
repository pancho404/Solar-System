using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Transform[] transforms;
    public Vector3 initialPos;
    public Quaternion initialRotation;
    GameObject[] stars = new GameObject[12];
    public float offset;
    int actualPosition = 0;
    private void Start()
    {
        transforms = new Transform[12];
        transform.position = initialPos;
        transform.rotation = initialRotation;
        stars = GameObject.FindGameObjectsWithTag("Stars");
        for (int i = 0; i < stars.Length; i++)
        {
            transforms[i] = stars[i].transform;
        }

    }


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            actualPosition++;
            if (actualPosition > transforms.Length - 1)
            {
                actualPosition = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            actualPosition--;
            if (actualPosition < 0)
            {
                actualPosition = transforms.Length - 1;
            }
        }

    }

    private void LateUpdate()
    {
        if (actualPosition == 0)
        {
            transform.position = initialPos;
            transform.rotation = initialRotation;
        }
        else
        {
            Vector3 newPos = new Vector3(stars[actualPosition - 1].transform.position.x - offset, transforms[actualPosition - 1].position.y, transforms[actualPosition - 1].position.z);
            transform.position = newPos;
            transform.LookAt(transforms[actualPosition - 1], Vector3.up);
        }
    }
}
