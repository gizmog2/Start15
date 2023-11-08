using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHelper : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        Debug.Log("ButtonClick()");
    }

    public void ToggleClick(bool isOn)
    {
        Debug.Log("ToggleClick " + isOn);
    }
}
