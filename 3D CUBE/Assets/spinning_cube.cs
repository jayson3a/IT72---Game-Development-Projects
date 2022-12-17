using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinning_cube : MonoBehaviour
{
    public Vector3 RotateAmount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount);
    }
}
