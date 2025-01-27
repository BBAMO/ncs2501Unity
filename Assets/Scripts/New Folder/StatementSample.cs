using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementSample : MonoBehaviour
{
    enum EAvengers {IronMan, SpiderMan,Hulk};
    void Start()
    {
        EAvengers avengers = EAvengers.IronMan;

        switch (avengers)
        {
            case EAvengers.IronMan:
                Debug.Log("Iron Man");
                break;
            case EAvengers.SpiderMan:
                Debug.Log("SpiderMan");
                break;
            case EAvengers.Hulk:
                Debug.Log("Hulk");
                break;
            default:
                Debug.Log("Avengers");
                break;
        }
        if (avengers == EAvengers.IronMan)
        {
            Debug.Log("Iron Man");
        }
        else if (avengers == EAvengers.SpiderMan)
        {
            Debug.Log("SpiderMan");
        }
        else if (avengers == EAvengers.Hulk)
        {
            Debug.Log("Hulk");
        }
        else
        {
            Debug.Log("Avengers");
        }
        /*
        int i1 = 1, i2 = 2;
        if (i1 > 12)
        {
            Debug.Log("It's True");
        }
        else if (i1 > i2)
        {
            Debug.Log("....");
        }
        else
        {
            Debug.Log("False");
            return;
        }
        */
    }

    void Update()
    {
        
    }
}
