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

    //GameObject 可以存在場景上的物件和專案內的預置物
    public GameObject Pipe;


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


    /// <summary>
    /// 生成水管的方法
    /// </summary>
    private void SpawnPipe()
    {
        Random.Range(1f, 100f);
        //三維向量 =new 三維向量(x,y,z)
        Vector3 p = new Vector3(6, Random.Range(-2f,1.4f), 0);
        //Quaternion.identity 零角度
        Instantiate(Pipe,p,Quaternion.identity);
        

    }

    private void Start()
    {

        //延遲調用(方法名稱+延遲時間)
        //Invoke("SpawnPipe", 1.5f);
        //重複延遲調用(方法名稱+延遲時間+間隔時間)
        InvokeRepeating("SpawnPipe",0,2f);
       
    }
}
