using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// 跳躍程式
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Range(0, 3000), Tooltip("a jump to the sky turn into rider kick!!")]
        private float heightJump = 350;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //input 建議在 update呼叫
        private void Update()
        {
            JumpKey();
        }

        //一秒固定50禎
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region 功能
        private void JumpKey()
        {
            //按下空白鍵跳躍
            //判斷式語句if,switch
            //if語法:  if(布林值){布林值為true時執行程式}
            if(Input.GetKeyDown(KeyCode.Space))
            {
                print("everybody Jump!!");
                clickJump = true;
            }
        }

        private void JumpForce()
        {
            if(clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }
        #endregion
    }

}
