using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // �v�f��5�̔z�������������
        int[] array = new int[5];

        // �z��̊e�v�f�ɒl��������
        array[0] = 20;
        array[1] = 30;
        array[2] = 40;
        array[3] = 50;
        array[4] = 60;

        // �z��̗v�f�����ׂĕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}