using UnityEngine;

namespace jerry
{/// <summary>
/// �R�AAPI static
/// </summary>
  public class staticAPI : MonoBehaviour
  {
        private int count;
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22,22,22);

        private void Start()
        {
         #region �Ұ�ǲ�
            //���o�R�A�ݩ�get.�y�k.���O�R�A�ݩʦW��
            print("�H����:" + Random.value);
            print("PI:" + Mathf.PI);
            print("�L���j:" + Mathf.Infinity);
            //�]�w�R�A�ݩ�set(read only)��Ū
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0,-9.8f);
            Time.timeScale = 3f;

            //�R�A��krandom.range(�����޼�)(�A�ίB�I��)
            float range = Random.Range(20.5f, 60.5f);
            print("�H���ƭ�:" + range);
            #endregion
            count = Camera.allCamerasCount;
            print("��v���ƶq:" + count+"�x");

            print("�ثe���x" + Application.platform);
            Physics.sleepThreshold = 10;
            print("�ίv�{�ɭ�" + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("�ɶ��j�p" + Time.timeScale);

            //�R�A��k�W��(�������޼�)
            print("9.999 �h���p���I�|�ˤ��J:" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a, b);
            print("<color=yellow>�Z��:" + distance + "</color>");

            Application.OpenURL("https://unity.com/");
        }
        private void Update()//fps 60s
        {
            #region �Ұ�ǲ�
            //�R�A��k.random.range(���)(���]�t�̤j��)
            int rangeint = Random.Range(1, 3);
            print("�H�����1~3:" + rangeint);
            #endregion
            //print("�O�_���U���N��" + Input.anyKeyDown);
            //print("�C���g�L�ɶ�" + Time.timeSinceLevelLoad);

            print("<color=red>�O�_���U�ť���:" + Input.GetKeyDown(KeyCode.Space) + "</color>");
        }
    }

}

