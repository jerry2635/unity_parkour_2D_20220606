using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// �D�R�AAPI
    /// �ݭn���骫��.�����W�����骫��.game obiect
    /// </summary>
    public class APInonSTATIC : MonoBehaviour
    {
        //�������
        //unity�ݩʭ��O�����ŭ�none
        //�D�R�AAPI
        [SerializeField]
        private GameObject turtle;
        [SerializeField]//�W�[UI���
        private Transform startpoint;
        
        private void Start()
        {
            //���o.�D�R�A�ݩ�.��Ū
            print("XX���Ұʪ��A" + turtle.activeInHierarchy);
            print("XX���w�]��h" + turtle);
            print("�_�I�y��" + startpoint.position);

            //�]�w
            turtle.tag = "Player";
            turtle.layer = 4;
            //startpoint.position = new Vector3(0, 5, 0);

            //�ϥ�.�D�R�A��k(�޼�)
            //turtle.SetActive(false);
        }

        private void Update()
        {
            //startpoint.Translate(1.3f, 0, 0);
            startpoint.Rotate(0, 0, 1.6f);
        }
    }

   
}