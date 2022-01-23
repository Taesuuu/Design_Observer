using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMnager : MonoBehaviour
{
    public Color blueObj;
    public Color redObj;
    public Color greenObj;

    public bool isOpen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnClick()
    {
        if(isOpen)
        {
            blueObj.Close();
            redObj.Close();
            greenObj.Close();
            isOpen = false;
        }
        else
        {
            blueObj.Open();
            redObj.Open();
            greenObj.Open();
            isOpen = true;
        }

    }
}
