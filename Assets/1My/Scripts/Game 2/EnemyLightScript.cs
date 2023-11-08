using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyLightScript : MonoBehaviour
{
    [SerializeField] float Speed = 10f;
    [SerializeField][Range(-1f, 1f)] float direction;
    bool _lookAt;
    GameObject _target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_target == null)
        {
            transform.Rotate(Vector3.up * direction * Time.deltaTime * Speed);
        }
        else
        {
            transform.LookAt(_target.transform);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _target = other.gameObject;
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
          
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            _target = null;
        }
            
    }
}
