using UnityEngine;

public class LearnMathod : MonoBehaviour
{
  private void Test()
    {
        print("123321");
    }

    private int A()
    {
        return 1000;
    
    }

    private void ASD (int Car,float Pig =100f)
    {
        print(Car);
        print(Pig);
    }

    private void Update()
    {
        Test();
    
        print(A());

        ASD(1001);
        ASD(1001,11111f);

    }   


}
