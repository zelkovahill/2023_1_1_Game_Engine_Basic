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

        long start = DateTime.Now.Ticks;    // ���� ����

        long count = 0;

        // �ݺ��� �����մϴ� 10000000tick = 1��
        while(start +(1000000)>DateTime.Now.Ticks)
        {
            count++;
        }
        Debug.Log(count + ": ��ŭ �ݺ��߽��ϴ�.");



        //�⺻���� 4-8 �� for �ݺ���

        // �迭�� �����մϴ�
        int[] intArray4 = { 1, 2, 3, 4, 5, 6 };

        // ����� ���̸� ����մϴ�.
        for (int i = intArray4.Length-1;i>=0;i--)
        {
            Debug.Log(intArray4[i]);
        }


        // �⺻���� 4-9 foreach �ݺ����� �迭
        


        // ������ �����մϴ�.
        string[] array = { "���", "��", "����", "����", "�ٳ���" };

        // �ݺ��� �����մϴ�.

        
        //foreach (var item in array)

        //�⺻���� 4-10 foreach �ݺ����� var Ű���� : �⺻���� 4-9�� ��� ����
        foreach (string item in array)
        {
            Debug.Log(item);
        }


        // �⺻ ���� 4-11 �� �Ƕ�̵� (1)


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
