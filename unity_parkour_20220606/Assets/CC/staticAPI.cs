using UnityEngine;

namespace jerry
{/// <summary>
/// �R�AAPI static
/// </summary>
  public class staticAPI : MonoBehaviour
  {
        private int count;

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


        }
        private void Update()//fps 60s
        {
            #region �Ұ�ǲ�
            //�R�A��k.random.range(���)(���]�t�̤j��)
            int rangeint = Random.Range(1, 3);
            print("�H�����1~3:" + rangeint);
            #endregion

        }
    }

}

