using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    //특수한 경우에 사용(렉 유발 가능)
    {
        //Debug.Log("FixedUpdate time :" + Time.deltaTime);
        Debug.Log($"FixedUpdate time :{Time.deltaTime}");
    }
    void Update()
    //기본 사용
    {
        //Debug.Log("Update time:" + Time.deltaTime);
        Debug.Log($"Update time: {Time.deltaTime}");
    }
}
