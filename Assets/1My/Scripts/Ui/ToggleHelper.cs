using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleHelper : MonoBehaviour
{
    TMP_InputField _myField;
    

    // Start is called before the first frame update
    void Start()
    {
        _myField = GameObject.FindObjectOfType<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged(bool isOn)
    {
        _myField.text = gameObject.name;
    }
}
