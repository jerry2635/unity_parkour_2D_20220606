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
        private float speedrun = 3.5f;
        [SerializeField,Header("跳躍高度"),Range(0,3000),Tooltip("你難道沒有腿嗎")]
        private float heightjump = 350;
        private Animator ani;
        private Rigidbody2D rig;


        #endregion

        #region 功能:系統實作
        //方法method
        //修飾詞 傳回資料 方法名稱(參數){程式}
        private void Run()
        {
            print("跑到不行~");
        }
        #endregion

        #region 事件:程式入口
        //喚醒事件.開始前執行一次.取得元件等等. <>泛型
        private void Awake()
        {
            //ani 蛙身上的 animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //開始事件:播放時.執行一次
        //初始化設定:重置基本數值設置
        private void Start()
        {
            //print("hello.kitty!!");   
        }
        //更新事件:每秒執行60次.fps.frame per second
        private void Update()
        {
            // print("<color=yellow>更新事件執行中~</color>");
            //呼叫方法: 名稱(對應引數);
            Run();
            rig.velocity = new Vector2(speedrun,rig.velocity.y);
        }

        #endregion

    }

}
