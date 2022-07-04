using UnityEngine;
using UnityEngine.SceneManagement;  //API 場景管理員
using TMPro;

namespace Jerry
{
    /// <summary>
    /// 管理結束畫面
    /// 過關或失敗
    /// </summary>
  public class ManagerFinal : MonoBehaviour
  {
        [SerializeField, Header("畫布")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        /// 遊戲結束的標語
        /// </summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;

            //monbehaviour 類別api 使用名稱重複呼叫(名稱,延遲時間,呼叫間隔)
            InvokeRepeating("FadeIn", 0, 0.2f);
        }

        ///淡入
        private void FadeIn()
        {
            //透明遞增
            groupFinal.alpha += 0.1f;
            //透明=1 啟動互動及遮擋
            if(groupFinal.alpha>=1)
            {
                groupFinal.interactable = true;//互動
                groupFinal.blocksRaycasts = true;//遮罩

                CancelInvoke("FadeIn");//取消所有呼叫
            }
        }

        /// 按鈕與程式作用方式
        /// 1.建立"公開"方法
        /// 2.button on click 設定腳本被點擊使用的方法
        public void Quit()
        {
            //Quit 不會在編輯器.網頁遊戲中被執行
            print("你成功地離開遊戲了!!");
            Application.Quit();
        }

        public void Replay()
        {
            SceneManager.LoadScene("遊戲場景");  //場景管理員 可以呼叫"名稱或者編碼"
        }
    }

}
