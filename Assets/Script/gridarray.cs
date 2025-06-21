using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

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




        bool BulbsActiveState()
        {
            GameObject[] tiles = GameObject.FindGameObjectsWithTag("bulb");

            foreach (GameObject tile in tiles)
            {
                Vector3 pos = tile.transform.localPosition;
                int x = Mathf.RoundToInt(pos.x / 0.75f);
                int y = Mathf.RoundToInt(pos.y / 0.75f);

                if (!gridarray.Instance.grid[y, x].Contains("5"))
                {
                    return false; // Found an inactive tile!
                }
            }

            return true; // All tiles are active!
        }

        string currentScene = SceneManager.GetActiveScene().name;
        int num = int.Parse(currentScene);
        num += 1;
        string name = num.ToString();
        if (BulbsActiveState()) { SceneManager.LoadScene(name); ; }



    }
}

