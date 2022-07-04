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
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGroud;

        private Animator ani;//����Y�g�w�q
        private Rigidbody2D rig;//�����Y�g�w�q
        private bool clickJump;//���D�P�w
        private bool isGround;//�a���P�w
        #endregion

        #region �ƥ�

        #region
        //ø�s�ϥ�
        //�b�s�边��ø�s���U�νu��.�Ϊ�.�Ϥ�:���|��ܦb�C��
        private void OnDrawGizmos()
        {
            //1.�M�w�C��
            Gizmos.color= colorCheckGround;
            //2.ø�s�ϥ�
            //transform.position ��e����y��
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);
        }
        
        #endregion

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
            CheckGround();
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
                //print("everybody Jump!!");
                clickJump = true;
            }
            
        }

        private void JumpForce()
        {
            if(clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
                
            }
            //else if (Input.GetKeyUp(KeyCode.Space))
            //{
            //   clickJump = false;
            //}
        }
        #endregion
        
        #region
        ///�ˬd�O�_�I��a�O
        private void CheckGround()
        {
            //2D�I����.2D���z.�л\�����ϰ�(�����I.�ؤo.����.�ϼh);
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0,layerCheckGroud);
            isGround = hit;
            //print("�I�쪺����:" + hit.name);
        }
        #endregion
    }

}
