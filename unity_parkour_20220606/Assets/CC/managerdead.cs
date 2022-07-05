using UnityEngine;

namespace Jerry //注意大小寫
{
    /// <summary>
    /// 死亡管理
    /// </summary>
 public class managerdead : MonoBehaviour
 {
        [SerializeField, Header("目標名稱")]
        private string nametarget = "其實我是蛙";
        [SerializeField, Header("結束管理")]
        private ManagerFinal managerFinal;
        [SerializeField, Header("CM攝影機管理器")]
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.name.Contains(nametarget)) //假使 碰撞目標
            {
                managerFinal.stringTitle = "你屎了"; //開啟標題
                managerFinal.enabled = true; //開啟終點程式
                goCM.SetActive(false); //可視開關
            }
        }
    }

}


