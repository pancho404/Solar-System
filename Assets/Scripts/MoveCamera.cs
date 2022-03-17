using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Vector3[] positions = new Vector3[11];
    public GameObject[] stars = new GameObject[11];
    public int offset;

    private void Start()
    {
        stars = GetComponents<GameObject>();
        foreach (GameObject gameObject in stars)
        { 
        
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
