using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dtd1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {


        // 3-7 switch 조건문 활용
        /*
         int inputNumber = 2021;

        if(inputNumber%2==0)
        {
        Debug.Log("짝수입니다.");
        }
        else
        {
        Debug.Log("짝수입니다.");
        }

        */


        int inputNumber = 2021;

        switch(inputNumber%2)
        {
            case 0:
                Debug.Log("짝수 입니다.");
                break;
            case 1:
                Debug.Log("홀수 입니다.");
                break;



        }


        //기본 예제 3-9 삼항 연산자

        //변수 선언
        string input = "-52273";
        int number2 = int.Parse(input);

        Debug.Log(number2>0?"학교에 살래요":"집에 가고싶어요");

        
        /*
         응용예제 3-1 입력 조건 받아 분할하기
        */

        Debug.Log("집에 가고 싶나요?");

        string line = "네 가고싶습니다";

        if (line.Contains("네"))
        {
            Debug.Log("집에 가고싶어요");
        }

        else
        {
            Debug.Log("아니요 학교에 살고 싶어요");

        }

        //기본예제 4-1 배열생성하고 요소에 접근하기
        int[] intArray = { 52, 273, 32, 65, 103 };

        intArray[0] = 0;

        Debug.Log(intArray[0]);
        Debug.Log(intArray[1]);
        Debug.Log(intArray[2]);
        Debug.Log(intArray[3]);

        //Length 속성

        int[] intArray1 = { 52, 273, 32, 65, 103 };

        Debug.Log(intArray1.Length);


        //기본예제 4-2 원하는 크기의 배열 생성
        int[] intArray2 = new int[100];

        //요소 출력
        Debug.Log(intArray2[0]);
        Debug.Log(intArray2[99]);

        /* 일반적인 숫자 자료형은 0, 문자자료형은 빈 문자열 ,이후에 알아보는 
        객체는 null로 초기화
        */
    }






}

