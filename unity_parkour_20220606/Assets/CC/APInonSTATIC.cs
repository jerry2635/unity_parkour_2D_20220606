using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// 非靜態API
    /// 需要實體物件.場景上的實體物件.game obiect
    /// </summary>
    public class APInonSTATIC : MonoBehaviour
    {
        //資料類型
        //unity屬性面板不為空值none
        //非靜態API
        [SerializeField]
        private GameObject turtle;
        [SerializeField]//增加UI欄位
        private Transform startpoint;
        
        private void Start()
        {
            //取得.非靜態屬性.唯讀
            print("XX的啟動狀態" + turtle.activeInHierarchy);
            print("XX的預設塗層" + turtle);
            print("起點座標" + startpoint.position);

            //設定
            turtle.tag = "Player";
            turtle.layer = 4;
            //startpoint.position = new Vector3(0, 5, 0);

            //使用.非靜態方法(引數)
            //turtle.SetActive(false);
        }

        private void Update()
        {
            //startpoint.Translate(1.3f, 0, 0);
            startpoint.Rotate(0, 0, 1.6f);
        }
    }

   
}