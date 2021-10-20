using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Text pointText;
    public int point;
    //������ ���� �����ϱ� ���� enum���� ����
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
            var velocity = GetComponent<Rigidbody>().velocity;
            velocity.x = 0;
            velocity.z = 0;
            GetComponent<Rigidbody>().velocity = velocity; //y�� �����ߴ�. 

            AddPoint(1);
        }

        BallMove();
    }

    private void AddPoint(int addPoint)
    {
        point += addPoint;
        pointText.text = point.ToString();
    }

    private void BallMove()
    {
        //Vector3 move = Vector3.zero;

        Vector3 move = (direction == Direction.Right) ? new Vector3(1, 0, 0) : new Vector3(0, 0, 1);

        //if (direction == Direction.Right)
        //    move = new Vector3(1, 0, 0);
        //else
        //    move = new Vector3(0, 0, 1);

        transform.Translate(move * speed * Time.deltaTime, Space.Self);//self�� ������
    }
}
