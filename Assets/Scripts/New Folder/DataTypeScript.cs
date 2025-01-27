using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{

    void Start()
    {
        // 값 유형 변수
        Vector3 pos = transform.position;
        //Debug.Log($"pos:{pos}");
        pos = new Vector3(0, 2, 0);
        //Debug.Log($"pos:{pos}");

        // reference 유형 변수
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}
