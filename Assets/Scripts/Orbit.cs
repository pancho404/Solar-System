using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform planetTarget;
    public int velocity;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(planetTarget.transform.position, planetTarget.transform.up, velocity * Time.deltaTime);
    }
}
