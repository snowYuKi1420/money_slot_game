using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelController : MonoBehaviour
{
    public GameObject Reel; //���[�����擾
    public GameObject Reel2;
    public GameObject Reel3;
    Vector3 initialpos; //�����ʒu
    Vector3 initialpos2;
    Vector3 initialpos3;
    float speed1; //���[���̉�]���x
    float speed2;
    float speed3;

    private void Awake()�@//�Q�[���J�n����
    {

        initialpos = this.Reel.transform.position;�@//�����ʒu���擾���Ă���
        initialpos2 = this.Reel2.transform.position;
        initialpos3 = this.Reel3.transform.position;
        speed1 = 0.35f;�@//���[���̉�]�X�s�[�h�̑��
        speed2 = 0.35f;
        speed3 = 0.35f;
    }
    private void Update()�@//�Q�[�����n�܂�����
    {
        this.Reel.transform.Translate(0, speed1, 0);�@//���[�����������i���j�ɓ�����
        this.Reel2.transform.Translate(0, speed2, 0);
        this.Reel3.transform.Translate(0, speed3, 0);
        if (Reel.transform.position.y < 22.46f)�@//���[������ԉ��ɗ�����
        {
            this.Reel.transform.position = initialpos;�@//�����ʒu�ɖ߂�
        }
        if (Reel2.transform.position.y < 22.46f)
        {
            this.Reel2.transform.position = initialpos2;
        }
        if (Reel3.transform.position.y < 22.46f)
        {
            this.Reel3.transform.position = initialpos3;
        }
    }
    public void stopReel() //���̊֐����{�^��1�������ƌĂ΂��
    {
        speed1 = 0; //���[���̉�]�X�s�[�h���O�ɂ���

    }
    public void stopReel2()
    {
        speed2 = 0;
    }
    public void stopReel3()
    {
        speed3 = 0;
    }
}
