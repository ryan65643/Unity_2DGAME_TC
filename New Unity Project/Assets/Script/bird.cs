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


    //事件:在特定時間以特定次數執行
    //開始:開始時,執行一次
    private void Start()
    {
        //輸出("訊息");
        print("Hello World");
    }


    private void Update()
    {
        print("Goodbye World");
    }
}


