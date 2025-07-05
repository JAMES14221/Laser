using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(this);

    }

    void Update()
    {
        AudioSource audio = GetComponent<AudioSource>();

        int AudioTrackVol()
        {
            GameObject[] tiles = GameObject.FindGameObjectsWithTag("audio_line");
            int count = 0;

            foreach (GameObject tile in tiles)
            {
                Vector3 pos = tile.transform.localPosition;
                int x = (int)(pos.x / 0.75f);
                int y = (int)(pos.y / -0.75f);

                if (gridarray.Instance.grid[y, x].Contains("5"))
                {
                    count++;
                }
            }
            return count;
        }
      
        float vol = ((float)AudioTrackVol())/5f;
        audio.volume = vol;

    }



}
