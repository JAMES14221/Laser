using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class curve : MonoBehaviour
{
    public Sprite active;
    public Sprite inactive;
    // Start is called before the first frame update
    void Start()
    {

    }

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
            gridarray.Instance.grid[grid_y, grid_x] = "12";
        }
        else if (zRotation == 270)
        {
            gridarray.Instance.grid[grid_y, grid_x] = "23";
        }
        else if (zRotation == 180)
        {
            gridarray.Instance.grid[grid_y, grid_x] = "34";
        }
        else if (zRotation == 90)
        {
            gridarray.Instance.grid[grid_y, grid_x] = "14";
        }


        // Just for readability

        int x = grid_x;
        int y = grid_y;



        // Check UP (y - 1)
        if (y > 0 &&
            gridarray.Instance.grid[y, x].Contains("4") &&
            gridarray.Instance.grid[y - 1, x].Contains("2") &&
            gridarray.Instance.grid[y - 1, x].Contains("5"))
        {
            gridarray.Instance.grid[y, x] += "5";
        }

        // Check DOWN (y + 1)
        if (y < gridarray.Instance.grid.GetLength(0) - 1 &&
            gridarray.Instance.grid[y, x].Contains("2") &&
            gridarray.Instance.grid[y + 1, x].Contains("4") &&
            gridarray.Instance.grid[y + 1, x].Contains("5"))
        {
            gridarray.Instance.grid[y, x] += "5";
        }

        // Check RIGHT (x + 1)
        if (x < gridarray.Instance.grid.GetLength(1) - 1 &&
            gridarray.Instance.grid[y, x].Contains("1") &&
            gridarray.Instance.grid[y, x + 1].Contains("3") &&
            gridarray.Instance.grid[y, x + 1].Contains("5"))
        {
            gridarray.Instance.grid[y, x] += "5";
        }

        // Check LEFT (x - 1)
        if (x > 0 &&
            gridarray.Instance.grid[y, x].Contains("3") &&
            gridarray.Instance.grid[y, x - 1].Contains("1") &&
            gridarray.Instance.grid[y, x - 1].Contains("5"))
        {
            gridarray.Instance.grid[y, x] += "5";
        }


        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (gridarray.Instance.grid[grid_y, grid_x].Contains("5")) { sr.sprite = active; } else { sr.sprite = inactive; }
        //Debug.Log(x);
        //Debug.Log(gridarray.Instance.grid[grid_y, grid_x-1]);
    }
}