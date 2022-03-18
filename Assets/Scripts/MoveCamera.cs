using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Vector3[] positions = new Vector3[13];
    public GameObject[] stars = new GameObject[12];
    public int offset;
    int actualPosition = 0;
    public Vector3 initialPos = new Vector3 { x = 0, y = 0, z = 0 };
    private void Start()
    {
        stars = GameObject.FindGameObjectsWithTag("Stars");
        for (int i = 0; i <= stars.Length; i++)
        {
            positions[i].x = stars[i].transform.position.x - offset;
        }
        Camera.main.transform.position = initialPos;
    }
    // Update is called once per frame
    void Update()
    {
        do
        {
            Camera.main.transform.position = positions[actualPosition];

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Camera.main.transform.position = positions[actualPosition];
                actualPosition++;
                if (actualPosition > 11)
                {
                    actualPosition = 11;
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Camera.main.transform.position = positions[actualPosition];
                actualPosition--;
                if (actualPosition > 0)
                {
                    actualPosition = 0;
                }
            }

        } while (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow));
    }
}
