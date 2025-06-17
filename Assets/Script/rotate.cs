using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{ 

    void OnMouseDown()
    {
        // Rotate 90 degrees around the Y axis
        transform.Rotate(0, 0, -90);
    }
}