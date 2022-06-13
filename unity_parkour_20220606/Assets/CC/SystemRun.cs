using UnityEngine;//用UT引擎 命名空間(API)

namespace Jerry
{
    //c#腳本轉變實體物件
    //game object 灰色線條方塊
    //腳本掛載成元件
    /// <summary>
    /// runsystem!!
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料:保存資料
        //公開:顯示在面板.允許其他存取.public
        //私人:不顯示在面板.不允許其他存取.private

        //serialize field 序列化欄位:顯示私人欄位
        //heder標題:中文可用
        //tooltip 提示:中文可用
        //range 範圍:僅限數值類型資料int.float.byte.long

        [SerializeField,Header("跑速"),Tooltip("要是你中文不好的話"),Range(0,100)]
        private float speedrun = .35f;
        [SerializeField,Header("跳躍高度"),Range(0,3000),Tooltip("你難道沒有腿嗎")]
        private float heightjump = 350;
        private Animator ani;
        private Rigidbody2D rig;


        #endregion

        #region 功能:系統實作

        #endregion

        #region 事件:程式入口
        //開始事件:播放時.執行一次
        //初始化設定:重置基本數值設置
        private void Start()
        {
            print("hello.kitty!!");   
        }

        #endregion

    }

}
