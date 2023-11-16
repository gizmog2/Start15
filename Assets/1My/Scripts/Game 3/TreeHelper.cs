using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHelper : MonoBehaviour
{
    [SerializeField] float AppleSpawnTime = 3;
    [SerializeField] Transform PointSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer", 0, AppleSpawnTime);
    }

    void Timer()
    {
        GetComponent<Animator>().SetTrigger("GetApple");
        /*GameObject apple = Instantiate(Resources.Load("Apple") ,PointSpawn.position ,Random.rotation) as GameObject;
        apple.GetComponent<Rigidbody>().AddForce(apple.transform.forward * 10);
        Destroy(apple, 10f);*/
    }

    void SpawnApple()
    {
        GameObject apple = Instantiate(Resources.Load("Apple"), PointSpawn.position, Random.rotation) as GameObject;
        apple.GetComponent<Rigidbody>().AddForce(apple.transform.forward * 10);
        Destroy(apple, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
