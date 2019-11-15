using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("分數")]
    [Range(0, 9999)]
    [Tooltip("遊戲分數")]
    public int Point = 0;
    [Header("最佳分數")]
    [Range(0, 9999)]
    [Tooltip("最佳遊戲分數")]
    public int BestPoint = 0;
    
    /// <summary>
    ///遊戲加分 
    /// </summary>
    /// <param name="ADD"></param>
    private void Mux(int ADD=1)
    {

    }

    /// <summary>
    /// 遊戲最佳分數設定
    /// </summary>
    private void BestPointS()
    {

    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    private void End()
    {

    }
}
