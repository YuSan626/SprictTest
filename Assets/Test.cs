using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 20;
        array[1] = 30;
        array[2] = 40;
        array[3] = 50;
        array[4] = 60;

        // 配列の要素をすべて表示する
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