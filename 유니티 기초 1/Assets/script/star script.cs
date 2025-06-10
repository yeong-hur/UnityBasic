using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starscript : MonoBehaviour
{
    // Start is called before the first frame update
    string star;
    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();



    }

    private void Phase1()
    {
        Debug.Log("Phase 1");

        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "*";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "*";
            }
            star += "\n";
        }

        Debug.Log("Phase 2\n" + star);



    }

    public void Phase3()
    {
        star = string.Empty;
        //페이즈 3

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;
        //페이즈 4

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;
        // 페이즈 5

        Debug.Log(star);
    }
    void Update()
    {
        
    }
}
