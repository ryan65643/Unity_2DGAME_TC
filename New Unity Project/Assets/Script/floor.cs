using UnityEngine;

public class floor : MonoBehaviour
{
    [Header("速度")]
    //[Range(0.1f, 50f)]
    [Tooltip("移動速度")]
    //靜態:此類別共用
    //隱藏

    public static float speed = 3f;


    public Transform Ground;
    /// <summary>
    /// 地板移動
    /// </summary>
    private void Move()
    {
        //Time.deltaTime 一個影格的時間
        Ground.Translate(-speed*Time.deltaTime, 0, 0);
    }

 
    private void Update()
    {
        Move();
    }
}
