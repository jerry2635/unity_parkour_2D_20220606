using UnityEngine;

namespace Jerry //�`�N�j�p�g
{
    /// <summary>
    /// ���`�޲z
    /// </summary>
 public class managerdead : MonoBehaviour
 {
        [SerializeField, Header("�ؼЦW��")]
        private string nametarget = "���ڬO��";
        [SerializeField, Header("�����޲z")]
        private ManagerFinal managerFinal;
        [SerializeField, Header("CM��v���޲z��")]
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.name.Contains(nametarget)) //���� �I���ؼ�
            {
                managerFinal.stringTitle = "�A�ˤF"; //�}�Ҽ��D
                managerFinal.enabled = true; //�}�Ҳ��I�{��
                goCM.SetActive(false); //�i���}��
            }
        }
    }

}


