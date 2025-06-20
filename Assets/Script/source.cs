using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class source : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {


        float zRotation = transform.eulerAngles.z;
        float pos_x = transform.localPosition.x;
        float pos_y = transform.localPosition.y;
        int grid_x = (int)(pos_x / 0.75f);
        int grid_y = (int)(pos_y / -0.75f);
        gridarray.Instance.grid[grid_y, grid_x] = "";

        if (zRotation == 0)
        {
            gridarray.Instance.grid[grid_y, grid_x] = "1";
        }
        else if (zRotation == 270)
        {
            gridarray.Instance.grid[grid_y, grid_x] = "2";
        }
        else if (zRotation == 180)
        {
            gridarray.Instance.grid[grid_y, grid_x] = "3";
        }
        else if (zRotation == 90)
        {
            gridarray.Instance.grid[grid_y, grid_x] = "4";
        }

            gridarray.Instance.grid[grid_y, grid_x] += "5";
    }
}
