using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {

        DontDestroyOnLoad(this);

    }
    // Update is called once per frame

}
