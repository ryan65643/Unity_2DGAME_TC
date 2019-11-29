
public class Pipe : floor
{

    //掛腳本的物件要有 Mesh Renderer
    //在所有攝影機看不到時執行一次
    //OnBecameVisible在所有攝影機看到時執行一次
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 4f);
    }

    
}
