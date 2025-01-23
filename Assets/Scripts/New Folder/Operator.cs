using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    void Start()
    {
        List<int> list = new List<int>();
        int intSize = sizeof(int);
        int fSize = sizeof(float);
        int bSize = sizeof(bool);

        Debug.Log($"int: {intSize}, float: {fSize}, bool: {bSize}");

        int i = 1;
        Debug.Log($"Before: {i}");
        Debug.Log($"++i: {++i}");
        Debug.Log($"After: {i}");

        i = 1;
        Debug.Log($"Before: {i}");
        Debug.Log($"i++: {i++}");
        Debug.Log($"After: {i}");

        for (int k = 0; k < 10; k++)
        {
            
        }
    }

    void Update()
    {
        
    }
}
