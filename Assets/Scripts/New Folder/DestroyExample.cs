using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExample : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }

    }
}
