using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    int numEnemies = 3;
    void Start()
    {
       ForeacheLoop();
    }

    void ForLoop()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number:" + i);
        }
        for (int i = numEnemies; i >= 0; i--)
        {
            Debug.Log("minus for : " + i);
        }
        
    }

    void whileLoop()
    {
        int cupsInTheSink = 4;
        
        while(cupsInTheSink > 0)
        {
            //Debug.Log ("i've washed a cup!");
            cupsInTheSink--;
        }
        

         cupsInTheSink = 4;
        for (int i = cupsInTheSink; i > 0; i--)
        {
            Debug.Log("i've washed a cup!");
        }
    
    }

    void DoWhile()
    {
        bool shouldContinue = false;

        do
        {
            print ("hello world!");
        }while(shouldContinue == true);
    }

    void ForeacheLoop()
    {
        string[]/*var*/ strings = new string[3];
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string/*var*/ item in strings)
        {
            //print(item);
        }

        for (int i = 0; i < strings.Length; i++)
        {
            print(strings[i]);
        }

    }

}
