using UnityEngine;      // �ޥ� Unity �R�W�Ŷ� (API)

// �R�W�Ŷ� �Ŷ��W��
// �h�H�}�o�i�H�ϥΩR�W�Ŷ��Ϲj�t���קK�Ĭ�
namespace KID
{
    // ���} ���O �}���W�� (�P���W���ɮצW�٬ۦP�A�j�p�g�@�ˡA����ϥΪŮ�P�S��r��#@!?)
    public class TopDownController : MonoBehaviour
    {
        #region ��ơG�O�s�t�λݭn���򥻸�ơA�Ҧp�G���ʳt�סB�ʵe�ѼƦW�ٻP���󵥵�
        // ��� field �y�k�G�׹��� ������� ���W�� (���w ��l��)�F
        // private �p�H�A�P public �ۤϡG���\��L�t�Φs��
        private float speed = 10.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDead = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �ƥ�G�{���J�f (Unity)�A���Ѷ}�o���X�ʨt�Ϊ����f
        // ����ƥ�G����C�������@���A�B�z��l�ơA���o��ơA��ƪ�l��
        private void Awake()
        {
            // ��X(�T��)�A�N�T����X�� Unity Console (����O) Ctrl + Shift + C
            // print("�ڬO����ƥ�~");

            // ��� ���w�� ���o����<����W��>()
            // <�x��> �x���G����������
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        // ��s�ƥ�G����C����H�C��� 60 ������A60 FPS (Frame Per Second)
        // �B�z�G����ʦ欰 - ���ʡB����B�Y��A���a��J - �ƹ��B��L�BĲ���B�n��
        private void Update()
        {
            print("�ڦb Update �ƥ�~");
        }
        #endregion

        #region ��k�G���������\�� (���z���B�t��k�ε{���϶�)
        #endregion
    }
}
