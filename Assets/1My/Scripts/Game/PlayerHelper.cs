using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelper : MonoBehaviour
{
    [SerializeField] GameObject[] Points;
    [SerializeField] float Speed;

    Vector3 _target;
    int _index;

    // Start is called before the first frame update
    void Start()
    {
        _target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_index < Points.Length -1)
            {
                _index++;
            }
            else
            {
                _index = 0;                
            }
            _target = Points[_index].transform.position;
        }
        else if(Input.GetMouseButtonDown(1))
        {
            if (_index > 0)
            {
                _index--;
            }
            else
            {
                _index = Points.Length -1;                
            }
            _target = Points[_index].transform.position;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, Speed * Time.deltaTime);
        }
    }
}
