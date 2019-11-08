using UnityEngine;

public class floor : MonoBehaviour
{
    [Header("速度")]
    [Range(0.1f, 50f)]
    [Tooltip("移動速度")]
    public float speed = 0.1f;
}
