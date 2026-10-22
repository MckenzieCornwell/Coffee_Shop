using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    private int beans=3;

    private int refills=0;
    private int maxRefills=3;

    void Start()
    {
        while (beans>0)
        {
            Debug.Log("Served a coffee. Beans left: "+beans);
            beans--;
        }

        do
        {
            Debug.Log("Serving coffee refill number: "+refills);
            refills++;
        }
        while (refills < maxRefills);
    }
}
