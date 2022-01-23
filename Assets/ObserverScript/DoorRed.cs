using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRed : Door
{
    bool isClosed;

    public ClickBtn manager;

    private void Start()
    {
        manager.AddDoor(this);

    }

    public override void OpenOrClose()
    {
        if (isClosed)
        {
            isClosed = false;
            Open();
        }
        else
        {
            isClosed = true;
            Close();
        }
    }

    void Open()
    {
        Debug.Log("Red 문이 열렸습니다.");
    }

    void Close()
    {
        Debug.Log("Red 문이 닫혔습니다.");
    }

}
