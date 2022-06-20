using UnityEngine;

namespace jerry
{/// <summary>
/// 靜態API static
/// </summary>
  public class staticAPI : MonoBehaviour
  {
        private int count;
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22,22,22);

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

            print("目前平台" + Application.platform);
            Physics.sleepThreshold = 10;
            print("睡眠臨界值" + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("時間大小" + Time.timeScale);

            //靜態方法名稱(對應的引數)
            print("9.999 去掉小數點四捨五入:" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a, b);
            print("<color=yellow>距離:" + distance + "</color>");

            Application.OpenURL("https://unity.com/");
        }
        private void Update()//fps 60s
        {
            #region 課堂學習
            //靜態方法.random.range(整數)(不包含最大數)
            int rangeint = Random.Range(1, 3);
            print("隨機整數1~3:" + rangeint);
            #endregion
            //print("是否按下任意鍵" + Input.anyKeyDown);
            //print("遊戲經過時間" + Time.timeSinceLevelLoad);

            print("<color=red>是否按下空白鍵:" + Input.GetKeyDown(KeyCode.Space) + "</color>");
        }
    }

}

