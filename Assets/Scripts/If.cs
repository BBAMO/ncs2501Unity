using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    float coffeeTemp = 85.0f;
    float hotLimitTemp = 70.0f;
    float coldLimitTemp = 40.0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        TempTest();

        coffeeTemp -= Time.deltaTime * 5f;
    }

    void TempTest()
    {
        if(coffeeTemp > hotLimitTemp)
        {
            print("Coffee is too hot.");
        }

        else if(coffeeTemp < coldLimitTemp)
        {
            print("Coffee is too cold");
        }

        else
        {
            print("Coffee is just right.");
        }
    }
}
