using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{
    private int mp = 53;          // �̗́�MP��
   


    // �U���p�̊֐��𗘗p���Ďg�p�ʂ̊֐�
    public void Attack()
    {
        Debug.Log("���@�U���������B");

     
    }

    // �h��p�̊֐��𗘗p����MP�ʂ�  �֐�
    public void Magic(int usemp)
    {

     if(mp>=usemp)
        {
            //MP���T�ȏ�
            // �c��hp�����炷
            this.mp -= usemp;
            Debug.Log("���@�U���������B�c��MP��" + this.mp);
        }
        else
        {
            //MP�T����
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �h��p�̊֐����Ăяo��
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