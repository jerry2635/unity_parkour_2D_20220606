using UnityEngine;


namespace Jerry //名字大小寫要一致
{
  /// <summary>
  /// 過關管理
  /// </summary>
  public class Managerpass : MonoBehaviour
  {
        [SerializeField, Header("目標名稱")]
        private string nametarget = "其實我是蛙";
        [SerializeField, Header("跑步系統")]
        private SystemRun systemRun;
        [SerializeField, Header("跳躍系統")]
        private SystemJump systemjump;
        [SerializeField, Header("結束管理器")]
        private ManagerFinal ManagerFinal;


        #region 其中一物件勾選trigger
        //碰撞時執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //如果 碰撞物體名稱
            if(collision.name.Contains(nametarget))
            {
                systemRun.enabled = false; //關閉跑步.跳躍系統
                systemjump.enabled = false;
                ManagerFinal.enabled = true;//啟動
                ManagerFinal.stringTitle = "恭喜過關!!";
            }
        }

        //碰撞離開時執行一次
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }

        //碰撞重疊時持續執行
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion

        #region 兩物件都沒有勾選trigger
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
