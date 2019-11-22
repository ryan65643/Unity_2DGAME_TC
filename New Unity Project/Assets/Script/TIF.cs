using UnityEngine;

public class TIF : MonoBehaviour
{

    public int hit;

    private void Start()
    {
        if (hit >= 50 && hit < 100)
        {
            print("攻擊*2");
        }

        else if (hit >= 100 && hit < 150)
        {
            print("攻擊*5");
        }
        else if (hit >= 150)
        {
            print("攻擊*10");
        }
        else
        {
            print("攻擊");
        }
    }
    }
