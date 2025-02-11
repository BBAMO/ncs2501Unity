using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodExample : MonoBehaviour
{
    public int temp;
    void Start()
    {
        int parameter1 = 1, parameter2 = 2;
        int Hi = IntMethod(parameter1, parameter2);
        Debug.Log(Hi);

        float parameter3 = 1.2f;
        VoidMethod(parameter3.ToString());
        VoidMethod(parameter3);
    }

    int IntMethod(int p1, int p2)
    {
        return (p1 + p2);
    }

    void VoidMethod(string message)
    {
        Debug.Log(message);
        //return; // 생략 가능
    }

    void VoidMethod(float fv)
    {
        Debug.Log($"FLOAT: {fv}");
    }

    
}
