using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        string a;

        for (int i = 0; i < 10; i++)
        {
            a = "";

            // 공백 추가
            for (int j = 0; j < 9 - i; j++)
            {
                a += " ";
            }

            // 별표 추가
            for (int o = 0; o < i + 1; o++)
            {
                a += "*";
            }

            Debug.Log(a);
        }









    }





    }

    
   


    

   
   

