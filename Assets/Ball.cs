using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    //방향을 쉽게 이해하기 위해 enum으로 관리
    public enum Direction
    {
        Right,
        Left,
    }

    Direction direction = Direction.Right;


    public float speed = 5;
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            direction = (direction == Direction.Right) ? Direction.Left : Direction.Right;
        }

        BallMove();
    }

    private void BallMove()
    {
        //Vector3 move = Vector3.zero;

        Vector3 move = (direction == Direction.Right) ? new Vector3(1, 0, 0) : new Vector3(0, 0, 1);

        //if (direction == Direction.Right)
        //    move = new Vector3(1, 0, 0);
        //else
        //    move = new Vector3(0, 0, 1);

        transform.Translate(move * speed * Time.deltaTime, Space.Self);//self가 로컬축
    }
}
