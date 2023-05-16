using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        long start = DateTime.Now.Ticks;    // 변수 선언

        long count = 0;

        // 반복을 수행합니다 10000000tick = 1초
        while(start +(1000000)>DateTime.Now.Ticks)
        {
            count++;
        }
        Debug.Log(count + ": 만큼 반복했습니다.");



        //기본예제 4-8 역 for 반복문

        // 배열을 생성합니다
        int[] intArray4 = { 1, 2, 3, 4, 5, 6 };

        // 요소의 길이를 출력합니다.
        for (int i = intArray4.Length-1;i>=0;i--)
        {
            Debug.Log(intArray4[i]);
        }


        // 기본예제 4-9 foreach 반복문과 배열
        


        // 변수를 선언합니다.
        string[] array = { "사과", "배", "포도", "딸기", "바나나" };

        // 반복을 수행합니다.

        
        //foreach (var item in array)

        //기본예제 4-10 foreach 반복문과 var 키워드 : 기본예제 4-9와 결과 같음
        foreach (string item in array)
        {
            Debug.Log(item);
        }


        // 기본 예제 4-11 별 피라미드 (1)


        string stars;
        for(int n = 0; n < 10; n++)
        {
            stars = "";
            for (int o = 0; o < n + 1; o++)
            {
                stars += "*";
            }
            Debug.Log(stars);
        }

       
    }

    
   


    

   
   
}
