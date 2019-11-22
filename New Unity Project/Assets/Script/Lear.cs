using UnityEngine;

public class Lear : MonoBehaviour
{
    public int a = 10, b = 3;
    public int c = 25, d = 3;
    private void Start()
    {
        #region
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);
  
        a = a + 1;
        print(a++);
        print(++a);
        print(a--);
        print(--a);

        a = a + 10;
        a += 10;
        print(a);
        #endregion
        #region
        print(c > d);
        print(c < d);
        print(c >= d);
        print(c <= d);
        print(c != d);
        print(c == d);
        #endregion
        #region
        print(true || false);
        #endregion
        print(c < 25 || d > 2);
    }


}
