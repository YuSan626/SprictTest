using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�z��@������
        int[] array = new int[5];

       //�z��@�l�@���
        array[0] = 20;
        array[1] = 30;
        array[2] = 40;
        array[3] = 50;
        array[4] = 60;

        //�v�f�����ׂĕ\��
        for(int i=0;i<5;i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
