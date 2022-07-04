using UnityEngine;
using UnityEngine.SceneManagement;  //API �����޲z��
using TMPro;

namespace Jerry
{
    /// <summary>
    /// �޲z�����e��
    /// �L���Υ���
    /// </summary>
  public class ManagerFinal : MonoBehaviour
  {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        /// �C���������лy
        /// </summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;

            //monbehaviour ���Oapi �ϥΦW�٭��ƩI�s(�W��,����ɶ�,�I�s���j)
            InvokeRepeating("FadeIn", 0, 0.2f);
        }

        ///�H�J
        private void FadeIn()
        {
            //�z�����W
            groupFinal.alpha += 0.1f;
            //�z��=1 �Ұʤ��ʤξB��
            if(groupFinal.alpha>=1)
            {
                groupFinal.interactable = true;//����
                groupFinal.blocksRaycasts = true;//�B�n

                CancelInvoke("FadeIn");//�����Ҧ��I�s
            }
        }

        /// ���s�P�{���@�Τ覡
        /// 1.�إ�"���}"��k
        /// 2.button on click �]�w�}���Q�I���ϥΪ���k
        public void Quit()
        {
            //Quit ���|�b�s�边.�����C�����Q����
            print("�A���\�a���}�C���F!!");
            Application.Quit();
        }

        public void Replay()
        {
            SceneManager.LoadScene("�C������");  //�����޲z�� �i�H�I�s"�W�٩Ϊ̽s�X"
        }
    }

}
