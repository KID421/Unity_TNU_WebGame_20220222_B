using UnityEngine;      // �ޥ� UnityEngine �R�W�Ŷ� (API)

// �R�W�Ŷ� �Ŷ��W��
// �h�H�}�o�i�H�ϥΩR�W�Ŷ��Ϲj�t���קK�Ĭ�
namespace KID
{
    // ���} ���O �}���W�� (�P���W���ɮצW�٬ۦP�A�j�p�g�@�ˡA����ϥΪŮ�P�S��r��#@!?)
    // summary �K�n�A�i�H�b���O�B��ơB�ƥ�P��k�W��K�[�T���׽u ///
    // ²�u����
    /// <summary>
    /// ���ⱱ��GTop Down ����
    /// </summary>
    public class TopDownController : MonoBehaviour
    {
        #region ��ơG�O�s�t�λݭn���򥻸�ơA�Ҧp�G���ʳt�סB�ʵe�ѼƦW�ٻP���󵥵�
        // ��� field �y�k�G
        // �׹��� ������� ���W�� (���w ��l��)�F
        // private �p�H�A�P public �ۤϡG���\��L�t�Φs��

        // [] Attribute �ݩʡG���U���O�B��ơB�ƥ�P��k
        // SerializeField �ǦC�����G���p�H�����ܦb�ݩʭ��O�W
        // Header("���D") ���D
        // Range(�̤p�ȡA�̤j��) �d�򭭨�
        [SerializeField, Header("���ʳt��"), Range(0, 100)]
        private float speed = 10.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDead = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;
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
            // print("�ڦb Update �ƥ�~");

            // �I�s�y�k�G��k�W��(�����޼�)�F
            GetInput();
            Move();
        }
        #endregion

        #region ��k�G���������\�� (���z���B�t��k�ε{���϶�)

        // ��k method �y�k�G
        // �׹��� �Ǧ^������� ��k�W�� (�Ѽ�) { �{���϶� }
        // void �L�Ǧ^

        /// <summary>
        /// ���o���a��J���
        /// ���kAD Horizontal
        /// �W�UWS Vertical
        /// </summary>
        private void GetInput()
        {
            // �ϥ��R�A��k�y�k static
            // ���O�W��.�R�A��k�W�� (�����޼�)�F
            // float h = ****; - �ϰ��ܼơG�ȯ�b�ӵ��c (�j�A����) �s��
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            // ��X�T��(�T��) - Ctrl + Shift + C �����O (Console)
            // print("���o�����b���ȡG" + h);
        }

        /// <summary>
        /// ����
        /// </summary>
        private void Move()
        {
            // �ϥΫD�R�A�ݩ� non-static
            // ���W��.�R�A�ݩʦW�� ���w ��
            // ����.�[�t�� = �s �G���V�q(�����A����) * �t��
            rig.velocity = new Vector2(h, v) * speed;
            // �ʵe���.�]�w���L��(�ѼƦW�١A���L��)
            // ���� ������ �s �Ϊ� ���� ������ �s
            ani.SetBool(parameterRun, h != 0 || v != 0);

            // �T���B��l�y�k
            // �x����Ghttps://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/operators/conditional-operator
            // ���L�� ? ���L�� ���� true : ���L�� ���� false
            // ���� >= 0 ���� 0 �_�h ���� 180
            // �ܧΤ���.�کԨ� = �s �T���V�q(X�AY�AZ)
            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        }
        #endregion
    }
}
