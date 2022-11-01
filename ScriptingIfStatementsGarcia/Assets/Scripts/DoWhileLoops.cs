using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoops : MonoBehaviour
{
    void Start()
    {
        bool shouldContinue = false;
        do
        {
            print("Hello world");
        } while (shouldContinue == true);
    }
}
