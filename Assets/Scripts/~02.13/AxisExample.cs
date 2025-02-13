using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float hRange;
    public float vRange;
    

    public TextMeshPro hTextOutPut;

    public TextMeshPro vTextOutPut;
    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float vPos = v * vRange;
        transform.position = new Vector3(xPos, 0, vPos);
        //textOutput.text = "Value Returned: " + h.ToString("F2");
        hTextOutPut.text = $"H Returned: {h:F2}";
        vTextOutPut.text = $"V Returned: {v:F2}";
    }
}
