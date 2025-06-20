using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class gridarray : MonoBehaviour
{
    public static gridarray Instance; // singleton reference

    public string[,] grid = new string[8, 15];

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        for (int y = 0; y < grid.GetLength(0); y++)
        {
            for (int x = 0; x < grid.GetLength(1); x++)
            {
                grid[y, x] = "0"; 
            }
        }
    }
}
