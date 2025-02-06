using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumSample : MonoBehaviour
{
    enum Direction {Error, None, North, East, South, West};
    void Start()
    {
        Direction myDirection;

        myDirection = Direction.None;

        myDirection = ReverseDirection(myDirection);
        if (myDirection != Direction.Error)
        Debug.Log($"Now Direction:{myDirection}");
    }

    Direction ReverseDirection(Direction dir)
    {
        /*
        if(dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
                dir = Direction.North;
        else if (dir == Direction.East)
                dir = Direction.West;
        else if (dir == Direction.West)
                dir = Direction.East;
        */
        switch (dir)
        {
            case Direction.North:
                dir = Direction.South;
                break;
            case Direction.South:
                dir = Direction.North;
                break;
            case Direction.East:
                dir = Direction.West;
                break;
            case Direction.West:
                dir = Direction.East;
                break;
            default:
                Debug.LogError($"알 수 없는 방향: {dir}");
                dir = Direction.Error;
                break;
        }
        return dir;
    }
}
