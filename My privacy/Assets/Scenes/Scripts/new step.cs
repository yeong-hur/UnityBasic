using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newstep : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int age = 25;

        if (age<20)
        {
            Debug.Log("어린이");
        }

        else if (age<30)
        {
            Debug.Log("늙은이");
        }
        else 
        {
            Debug.Log("노인네");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
