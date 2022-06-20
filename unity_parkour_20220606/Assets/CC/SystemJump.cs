using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// ���D�{��
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Range(0, 3000), Tooltip("a jump to the sky turn into rider kick!!")]
        private float heightJump = 350;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //input ��ĳ�b update�I�s
        private void Update()
        {
            JumpKey();
        }

        //�@��T�w50��
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region �\��
        private void JumpKey()
        {
            //���U�ť�����D
            //�P�_���y�yif,switch
            //if�y�k:  if(���L��){���L�Ȭ�true�ɰ���{��}
            if(Input.GetKeyDown(KeyCode.Space))
            {
                print("everybody Jump!!");
                clickJump = true;
            }
        }

        private void JumpForce()
        {
            if(clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }
        #endregion
    }

}
