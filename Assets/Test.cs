using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{
    private int mp = 53;          // 体力→MP量
   


    // 攻撃用の関数を利用して使用量の関数
    public void Attack()
    {
        Debug.Log("魔法攻撃をした。");

     
    }

    // 防御用の関数を利用してMP量の  関数
    public void Magic(int usemp)
    {

     if(mp>=usemp)
        {
            //MPが５以上
            // 残りhpを減らす
            this.mp -= usemp;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            //MP５未満
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 防御用の関数を呼び出す
        lastboss.Magic(5);

        for(int i=0;i<10;i++)
        {
            lastboss.Magic(5);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}