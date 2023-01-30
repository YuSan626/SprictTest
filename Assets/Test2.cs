using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //配列　初期化
        int[] array = new int[5];

       //配列　値　代入
        array[0] = 20;
        array[1] = 30;
        array[2] = 40;
        array[3] = 50;
        array[4] = 60;

        //要素をすべて表示
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
