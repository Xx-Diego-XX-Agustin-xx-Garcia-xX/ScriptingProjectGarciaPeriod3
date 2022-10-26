using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            Debug.Log("Coffee is too hot.");
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            Debug.Log("Coffee is too cold.");
        }
        else
        {
            Debug.Log("Coffee is just right.");
        }
    }
}