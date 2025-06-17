using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridreact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private gridarray gridscript;
    void Update()
    {

    // Get the parent script component
    gridscript = GetComponentInParent<gridarray>();

    // Check if the parent script was found
    if (gridscript != null)
    {
        // Access the parent's variable
        Debug.Log("Parent variable: " + gridscript.grid);
    }
    else
{
    Debug.LogWarning("Parent script not found.");
}

        float zRotation = transform.eulerAngles.z;
        float pos_x = transform.position.x;
        float pos_y = transform.position.y;
        float grid_x = pos_x / 0.75f;
        float grid_y = pos_y / 0.75f;
        if (zRotation == 0)
        {

        }


    }
}



