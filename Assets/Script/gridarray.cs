using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class gridarray : MonoBehaviour
{
    // Start is called before the first frame update


    public int[,] grid = new int [8,15];

    void Start()
    {

        for (int y = 0; y < grid.GetLength(0); y++)
        {
            for (int x = 0; x < grid.GetLength(1); x++)
            {
                grid[x, y] = 0;
            }
        }
        Console.WriteLine(grid);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
