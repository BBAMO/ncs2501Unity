using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;

 public class Class1
    {
        public int m_IntVariable;
        private string m_StringVariable;

        public void DebugLog(string message)
        {
            m_StringVariable = message;
            Debug.Log(message);
        }
    }
   
public class ClassExample : MonoBehaviour
{
    
    private Class1 m_Class1 = new Class1();
    
    void Start()
    {
        m_Class1.DebugLog("Example");
    }

}
