using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TryCatchExample : MonoBehaviour
{
    GameObject go;

    void Start()
    {
        //go = new GameObject();

        try
        {
            Debug.Log(go.name);
        }
        catch (DivideByZeroException dz)
        {
            Debug.Log($"나누기 0 예외 : {dz}");
        }
        catch (IndexOutOfRangeException ne)
        {
            Debug.LogWarning($"IOR ~ 발생 : {ne} "); 
        }
        catch (Exception ex) // Exception 문은 가장 마지막에 쓴다.
        {
            Debug.LogWarning($"예외 발생! : {ex}");
        }
        Debug.Log("끝");
    }
    void Example2()
    {
        go = new GameObject();

        try
        {
            Debug.Log(go.name);
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"예외 발생! : {ex}"); // 예외 발생 시 catch 문 확인, 실행
        }
        finally 
        {
            Debug.Log("여기는 실행됩니다."); // 예외가 발생하든 안 하든 반드시 실행되는 문
        }
        Debug.Log("여기는 실행될 때도 있고 아닐 때도 있습니다."); // 캐치가 없을 시 실행 안 됨
    }

    void Example1()
    {
        try
        {
            Debug.Log(go.name);
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"예외 발생! : {ex}");
        }
        Debug.Log("여기도 실행됨");
    }

}
