using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBtn : MonoBehaviour
{
    public List<Door> doors = new List<Door>();

    public void AddDoor(Door door)
    {
        if (doors.Contains(door))
        {
            Debug.Log("이미 추가 되어 있습니다");
        }
        else
        {
            doors.Add(door);
        }
    }

    public void RemoveDoor(Door door)
    {
        if (doors.Contains(door))
        {
            doors.Remove(door);
        }
        else
        {
            Debug.Log("없습니다");
        }
    }

    public void OnClickSwitchButton()
    {
        NotifyDoors();
    }

    public void NotifyDoors()
    {
        foreach (Door door in doors)
        {
            door.OpenOrClose();
        }
    }
}
