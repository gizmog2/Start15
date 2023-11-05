using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField] Transform endPoint;
    [SerializeField] float speed;
    [SerializeField] float sDistance;

    private Vector3 currentPosition;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;
        float dist = Vector3.Distance(transform.position, endPoint.position);
        MoveToPoint();


        if (dist <= sDistance)
        {
           transform.position = currentPosition;
        }
        else
        {
            MoveToPoint();
        }
    }

    private void MoveToPoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPoint.position, speed * Time.deltaTime);

    }
}
