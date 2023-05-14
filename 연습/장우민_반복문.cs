using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dtd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    //기본예제 4-3 반복문 이용하기
    
    //변수를 선언합니다.
    int j = 0;
    int[] intArray3 = {52,273,32,65,103};
    
    // 반복을 수행합니다.
    while(j<intArray3.Length)
    {
    
    //출력합니다.
    Debug.Log(j+"번째 출력:"+intArray3[j]);
    
    //탈출을 위해 변수를 더합니다.
    j++;
}

//기본예제 4-4 do while 반복문 활용하기

int k =0;
do

{
Debug.Log(k+")한번은 반드시 출력됨.");
++k;
}

while(k<4);

//기본예제 4-5 for 반복문으로 덧셈하기

int output=0;

//반복문 수행
for(int L = 0; L<=100; L++)
{

output+=L;

}
Debug.Log(output);


//기본예제 4-7 한글 전부 출력하기

for(int m='가';m<='힝';m++)
{
Debug.Log((char)m);
}




    
    
    
    
        
    }

   
}
