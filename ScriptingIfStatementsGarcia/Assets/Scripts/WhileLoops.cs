using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int cupsInTheSink = 4;
    void Start()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log("Cup washed");
            cupsInTheSink--;
        }
    }
}
