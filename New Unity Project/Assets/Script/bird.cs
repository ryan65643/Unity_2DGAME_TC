using UnityEngine;

public class bird : MonoBehaviour
{
    [Header("跳躍")]
    [Range(10, 5000)]
    [Tooltip("跳躍高度")]
    public float hight = 10;
    [Header("死亡")]
    [Tooltip("判斷是否死亡")]
    public bool dead ;
    [Header("旋轉角度")]
    [Range(0,360)]
    public float R=360;
    public GameObject goGM, goS ,W,V,Z;

    public Rigidbody2D go2D;

    //碰撞開始事件:物件碰撞開始時執行一次(紀錄物件碰撞資訊)
   // private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    print(collision.gameObject.name);
     //   Death();
    //}

        //觸發開始事件:物件觸發開始時執行一次(紀錄物件碰撞資訊)-針對IsTrigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Death();
    }
    /// <summary>
    /// 小雞跳躍
    /// </summary>
    private void Jump()
    {
        if (dead)
        {
            W.SetActive(true);
            V.SetActive(true);
            Z.SetActive(true);

            return;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            goS.SetActive(true);
            goGM.SetActive(true);
            go2D.Sleep();
            go2D.gravityScale = 1;
            go2D.AddForce(new Vector2(0, hight));
        }
        go2D.SetRotation(R* go2D.velocity.y);
    }

    /// <summary>
    /// 小雞死亡
    /// </summary>
    private void Death()
    {
        dead = true;
    }

    /// <summary>
    /// 穿過水管
    /// </summary>
    private void Through()
    {
 
    }


    //事件:在特定時間以特定次數執行
    //開始:開始時,執行一次
    private void Start()
    {
        //輸出("訊息");
        print("Hello World");

    }


    private void Update()
    {
        Jump();
    }


}


