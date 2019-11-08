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
}
