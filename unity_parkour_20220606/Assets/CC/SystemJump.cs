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
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGroud;

        private Animator ani;//控制器縮寫定義
        private Rigidbody2D rig;//剛體縮寫定義
        private bool clickJump;//跳躍判定
        private bool isGround;//地面判定
        #endregion

        #region 事件

        #region
        //繪製圖示
        //在編輯器內繪製輔助用線條.形狀.圖片:不會顯示在遊戲
        private void OnDrawGizmos()
        {
            //1.決定顏色
            Gizmos.color= colorCheckGround;
            //2.繪製圖示
            //transform.position 當前物件座標
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);
        }
        
        #endregion

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
            CheckGround();
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
                //print("everybody Jump!!");
                clickJump = true;
            }
            
        }

        private void JumpForce()
        {
            if(clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
                
            }
            //else if (Input.GetKeyUp(KeyCode.Space))
            //{
            //   clickJump = false;
            //}
        }
        #endregion
        
        #region
        ///檢查是否碰到地板
        private void CheckGround()
        {
            //2D碰撞器.2D物理.覆蓋盒型區域(中心點.尺寸.角度.圖層);
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0,layerCheckGroud);
            isGround = hit;
            //print("碰到的物件:" + hit.name);
        }
        #endregion
    }

}
