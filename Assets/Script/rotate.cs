using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rotate : MonoBehaviour
{

    void OnMouseDown()
    {
        // Rotate 90 degrees around the Y axis
        transform.Rotate(0, 0, -90);
        for (int y = 0; y < gridarray.Instance.grid.GetLength(0); y++)
        {
            for (int x = 0; x < gridarray.Instance.grid.GetLength(1); x++)
            {
                gridarray.Instance.grid[y, x] = "";
            }
        }


    }




}
