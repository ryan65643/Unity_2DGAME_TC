using UnityEngine;

public class APITEST : MonoBehaviour
{

    private void Start()
    {
        Debug.Log(Mathf.PI);
        Debug.Log(Random.value);
    }

    private void Update()
    {
        print(Input.GetKeyDown("mouse 0"));
        print(Input.GetKeyDown(KeyCode.Mouse0));

    }
}


