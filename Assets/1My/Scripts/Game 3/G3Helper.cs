using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class G3Helper : MonoBehaviour
{
    int _appleCounter;
    [SerializeField] int _treePrice = 5;
    [SerializeField] TMP_Text AppleCounter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if (hit.collider.gameObject == null)
                {
                    return;
                }                

                if (hit.collider.name.Contains("Apple"))
                {
                    _appleCounter++;
                    AppleCounter.text = _appleCounter.ToString();
                    Destroy(hit.collider.gameObject);

                }

                if (hit.collider.name.Contains("Floor") && _appleCounter >= _treePrice)
                {                    
                    _appleCounter -= _treePrice;
                    Vector3 pointPosition = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                    GameObject tree = Instantiate(Resources.Load("Tree"), pointPosition, Quaternion.identity) as GameObject;
                }
            }

        }
    }
}
