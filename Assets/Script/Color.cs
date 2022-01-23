using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    public string colorName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        Debug.Log(colorName + "이 열렸습니다.");
    }

    public void Close()
    {
        Debug.Log(colorName + "이 닫혔습니다.");
    }
}
