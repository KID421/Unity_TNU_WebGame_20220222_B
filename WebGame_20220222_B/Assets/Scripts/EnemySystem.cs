using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ĤH�t��
    /// </summary>
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;
        [SerializeField, Header("���a����W��")]
        private string namePlayer = "�߫}";

        private Transform traPlayer;

        float a = 0;
        float b = 1000;

        private void Awake()
        {
            // ���a�ܧ� = �C������.�M��(����W��) �� �ܧ�
            traPlayer = GameObject.Find(namePlayer).transform;

            /** // �ƾ�.����(A�AB�A�ʤ���)
            float result = Mathf.Lerp(0, 100, 0.5f);
            print("0 �P 100 �� 0.5 ���ȵ��G�G" + result);
            */
        }

        private void Update()
        {
            /** ���մ���
            a = Mathf.Lerp(a, b, 0.5f);
            print("���յ��G�G" + a);
            */

            MoveToPlayer();
        }

        /// <summary>
        /// ���ʨ쪱�a��m
        /// </summary>
        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;      // A �I�G�ĤH�y��
            Vector3 posPlayer = traPlayer.position;     // B �I�G���a�y��

            // �ĤH�y�� = ����(�ĤH�y�СA���a�y�СA�ʤ��� * �t�� * �@�V���ɶ�)
            transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

            // y = �ĤH X �j�� ���a X ? 180 : 0 - �p�G�ĤH X �j�󪱮a X ���׳]�w�� 180 �_�h 0
            float y = transform.position.x > traPlayer.position.x ? 180 : 0;
            transform.eulerAngles = new Vector3(0, y, 0);
        }
    }
}

