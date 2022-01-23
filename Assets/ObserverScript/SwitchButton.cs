using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : MonoBehaviour
{
    public delegate void DoorNotification();
    public event DoorNotification doorNotification;

    public void AddDoor(DoorNotification notification)
    {
        foreach (DoorNotification n in doorNotification.GetInvocationList())
        {
            if (n == notification)
            {
                Debug.Log("이미 있습니다");
                return;
            }
        }

        doorNotification += notification;
    }

    public void RemoveDoor(DoorNotification notification)
    {
        foreach (DoorNotification n in doorNotification.GetInvocationList())
        {
            if (n == notification)
            {
                doorNotification -= notification;
                return;
            }
        }

        Debug.Log("존재하지 않습니다");
    }

    public void OnClickSwitchButton()
    {
        NotifyDoors();
    }

    public void NotifyDoors()
    {
        doorNotification.Invoke();
    }
}
