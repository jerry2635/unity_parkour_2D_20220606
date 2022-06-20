using UnityEngine;//��UT���� �R�W�Ŷ�(API)

namespace Jerry
{
    //c#�}�����ܹ��骫��
    //game object �Ǧ�u�����
    //�}������������
    /// <summary>
    /// runsystem!!
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���:�O�s���
        //���}:��ܦb���O.���\��L�s��.public
        //�p�H:����ܦb���O.�����\��L�s��.private

        //serialize field �ǦC�����:��ܨp�H���
        //heder���D:����i��
        //tooltip ����:����i��
        //range �d��:�ȭ��ƭ��������int.float.byte.long

        [SerializeField,Header("�]�t"),Tooltip("�n�O�A���夣�n����"),Range(0,100)]
        private float speedrun = 3.5f;
        [SerializeField,Header("���D����"),Range(0,3000),Tooltip("�A���D�S���L��")]
        private float heightjump = 350;
        private Animator ani;
        private Rigidbody2D rig;


        #endregion

        #region �\��:�t�ι�@
        //��kmethod
        //�׹��� �Ǧ^��� ��k�W��(�Ѽ�){�{��}
        private void Run()
        {
            print("�]�줣��~");
        }
        #endregion

        #region �ƥ�:�{���J�f
        //����ƥ�.�}�l�e����@��.���o���󵥵�. <>�x��
        private void Awake()
        {
            //ani �쨭�W�� animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //�}�l�ƥ�:�����.����@��
        //��l�Ƴ]�w:���m�򥻼ƭȳ]�m
        private void Start()
        {
            //print("hello.kitty!!");   
        }
        //��s�ƥ�:�C�����60��.fps.frame per second
        private void Update()
        {
            // print("<color=yellow>��s�ƥ���椤~</color>");
            //�I�s��k: �W��(�����޼�);
            Run();
            rig.velocity = new Vector2(speedrun,rig.velocity.y);
        }

        #endregion

    }

}
