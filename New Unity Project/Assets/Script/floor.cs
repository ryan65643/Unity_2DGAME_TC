using UnityEngine;

public class floor : MonoBehaviour
{
    [Header("速度")]
    [Range(0.1f, 50f)]
    [Tooltip("移動速度")]
    public float speed = 0.1f;


    public Transform Ground;
   
    /// <summary>
    /// 地板移動
    /// </summary>
    private void Move()
    {
        
    }


    private void Update()
    {
        Ground.Translate(-speed, 0, 0);
    }
}
