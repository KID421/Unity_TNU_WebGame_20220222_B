using UnityEngine;

namespace KID
{
    /// <summary>
    /// �Z�����
    /// 1. ����t�� float
    /// 2. �����O   float
    /// 3. �_�l�ƶq int
    /// 4. �̤j�ƶq int 
    /// 5. ���j�ɶ� float 
    /// 6. �ͦ���m
    /// 7. �Z���w�s��
    /// 8. �����V
    /// </summary>
    // ScriptableObject �}���ƪ���
    // �@�ΡG�N�}��������ܦ������x�s�� Project �� (�X�R�P���@�ʨ�)
    // CreateAssetMenu �P ScriptableObject �f�t�ϥ�
    // �@�ΡG�b Project �إߦ��}���ƪ��󪺿��P�ɮצW��
    // menuName ���W�١BfileName �ɮצW��
    [CreateAssetMenu(menuName = "KID/Data Weapon", fileName = "Data Weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("����t��"), Range(0, 5000)]
        public float speed = 500;
        [Header("�����O"), Range(0, 100)]
        public float attack = 10;
        [Header("�_�l�ƶq"), Range(1, 10)]
        public int countStart = 1;
        [Header("�̤j�ƶq"), Range(1, 20)]
        public int countMax = 3;
        [Header("���j�ɶ�"), Range(0, 5)]
        public float interval = 3.5f;

        // �������[] �}�C - ��Ƶ��c
        // �@�ΡG�x�s�h���ۦP���������
        [Header("�ͦ���m")]
        public Vector3[] v3SpawnPoint;
        [Header("�Z���w�s��")]
        public GameObject goWeapon;
        [Header("�����V")]
        public Vector3 v3Direction;
    }
}