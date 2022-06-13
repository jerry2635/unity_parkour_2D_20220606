using UnityEngine;

namespace jerry
{/// <summary>
/// 靜態API static
/// </summary>
  public class staticAPI : MonoBehaviour
  {
        private int count;

        private void Start()
        {
         #region 課堂學習
            //取得靜態屬性get.語法.類別靜態屬性名稱
            print("隨機值:" + Random.value);
            print("PI:" + Mathf.PI);
            print("無限大:" + Mathf.Infinity);
            //設定靜態屬性set(read only)唯讀
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0,-9.8f);
            Time.timeScale = 3f;

            //靜態方法random.range(對應引數)(適用浮點數)
            float range = Random.Range(20.5f, 60.5f);
            print("隨機數值:" + range);
            #endregion
            count = Camera.allCamerasCount;
            print("攝影機數量:" + count+"台");


        }
        private void Update()//fps 60s
        {
            #region 課堂學習
            //靜態方法.random.range(整數)(不包含最大數)
            int rangeint = Random.Range(1, 3);
            print("隨機整數1~3:" + rangeint);
            #endregion

        }
    }

}

