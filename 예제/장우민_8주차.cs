using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dtd1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {


        // 3-7 switch ���ǹ� Ȱ��
        /*
         int inputNumber = 2021;

        if(inputNumber%2==0)
        {
        Debug.Log("¦���Դϴ�.");
        }
        else
        {
        Debug.Log("¦���Դϴ�.");
        }

        */


        int inputNumber = 2021;

        switch(inputNumber%2)
        {
            case 0:
                Debug.Log("¦�� �Դϴ�.");
                break;
            case 1:
                Debug.Log("Ȧ�� �Դϴ�.");
                break;



        }


        //�⺻ ���� 3-9 ���� ������

        //���� ����
        string input = "-52273";
        int number2 = int.Parse(input);

        Debug.Log(number2>0?"�б��� �췡��":"���� ����;��");

        
        /*
         ���뿹�� 3-1 �Է� ���� �޾� �����ϱ�
        */

        Debug.Log("���� ���� �ͳ���?");

        string line = "�� ����ͽ��ϴ�";

        if (line.Contains("��"))
        {
            Debug.Log("���� ����;��");
        }

        else
        {
            Debug.Log("�ƴϿ� �б��� ��� �;��");

        }

        //�⺻���� 4-1 �迭�����ϰ� ��ҿ� �����ϱ�
        int[] intArray = { 52, 273, 32, 65, 103 };

        intArray[0] = 0;

        Debug.Log(intArray[0]);
        Debug.Log(intArray[1]);
        Debug.Log(intArray[2]);
        Debug.Log(intArray[3]);

        //Length �Ӽ�

        int[] intArray1 = { 52, 273, 32, 65, 103 };

        Debug.Log(intArray1.Length);


        //�⺻���� 4-2 ���ϴ� ũ���� �迭 ����
        int[] intArray2 = new int[100];

        //��� ���
        Debug.Log(intArray2[0]);
        Debug.Log(intArray2[99]);

        /* �Ϲ����� ���� �ڷ����� 0, �����ڷ����� �� ���ڿ� ,���Ŀ� �˾ƺ��� 
        ��ü�� null�� �ʱ�ȭ
        */
    }






}

