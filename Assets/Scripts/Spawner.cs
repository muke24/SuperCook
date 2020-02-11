using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject customer;
    public Transform spawnPos;

    private IEnumerator coroutine;

    void Start()
    {
        
        print("Starting " + Time.time);

        coroutine = CustomerSpawn(10.0f);
        StartCoroutine(coroutine);

        print("Counting " + Time.time);
    }

    private IEnumerator CustomerSpawn(float waitTime)
    {
        while (true)
        {
            Instantiate(customer);
            yield return new WaitForSeconds(waitTime);
            print("Spawned Customer at the time of " + Time.time);
        }
        
    }

    void Update()
    {
        if (coroutine == CustomerSpawn(0.0f))
        {
            
            CustomerSpawn(10.0f);
        }
    }
}
