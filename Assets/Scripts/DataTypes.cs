using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypes : MonoBehaviour
{
    int gv; //전역 변수
    // Start is called before the first frame update
    void Start()
    {
        var i = 1;
        var f = 2f;
        var c = 'c';
        var s = "string";

        //데이터 형식이 같다면 한 줄에 여러 변수 선언 가능
        //int age = 46;
        //int brother = 2;
        int age = 46, brother = 2;
        float f1 = 1.0f, f2 = 2.3f;
        int i1, i2 =4, i3; //권장하지 않는 형태(하나만 값을 넣는 등)
        //var v1 = 1, v2 = 2; / var은 같은 줄 X, 값 안주기 X
        
        string str = new string("abc");
        
        int number1;
        number1 = 1;
        int newone = 2;
        float number3 = 3, number4 = 4f;
        bool isBool = true; //fasle

        Debug.Log(number1.ToString());
        Debug.Log(newone.ToString());
        Debug.Log(number3.ToString());
        Debug.Log(number4.ToString());
        Debug.Log(isBool.ToString());

        // 값을 지정하지 않은 지역 변수는 사용하면 에러
        // Debug.Log(i1);
        // 전역 변수는 값을 지정하지 않고도 사용할 수 있다
        // 지역 변수는 값을 할당하지 않으면 에러가 발생한다
        Debug.Log("gv:" + gv);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
