using UnityEngine;


namespace Jerry //�W�r�j�p�g�n�@�P
{
  /// <summary>
  /// �L���޲z
  /// </summary>
  public class Managerpass : MonoBehaviour
  {
        [SerializeField, Header("�ؼЦW��")]
        private string nametarget = "���ڬO��";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemRun;
        [SerializeField, Header("���D�t��")]
        private SystemJump systemjump;
        [SerializeField, Header("�����޲z��")]
        private ManagerFinal ManagerFinal;


        #region �䤤�@����Ŀ�trigger
        //�I���ɰ���@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //�p�G �I������W��
            if(collision.name.Contains(nametarget))
            {
                systemRun.enabled = false; //�����]�B.���D�t��
                systemjump.enabled = false;
                ManagerFinal.enabled = true;//�Ұ�
                ManagerFinal.stringTitle = "���߹L��!!";
            }
        }

        //�I�����}�ɰ���@��
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }

        //�I�����|�ɫ������
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion

        #region �⪫�󳣨S���Ŀ�trigger
        private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }

        #endregion

    }

}
