using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Text pointText;
    public int point;
    Rigidbody rigid;
    //������ ���� �����ϱ� ���� enum���� ����
    public enum Direction
    {
        Right,
        Left,
    }

    Direction direction = Direction.Right;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //enabled = false; //ó������ Update���� �� ���ư��� ���� ���鿡 ������ ����� ������ �����̵��� ������Ѵ�. 
        //yield return new WaitForSeconds(1);
        //enabled = true;
        //rigid.velocity = Vector3.zero;
    }
    public float speed = 5;
    public float gameOverHeight = 1.3f;
    // Update is called once per frame
    void Update()
    {
        //if(rigid.velocity.x != 0)
        //{
        //    Debug.LogWarning("������ ������ ���� ���� ����");
        //    return;
        //}
        if(transform.position.y < gameOverHeight)
        {
            Debug.LogWarning("���� ����");
            return; //���⼭ �����ع����� ������ �� �̻� �������� �ʴ´�. 
            //BallMove�� �������� �ʱ� ������.
        }
        if(Input.anyKeyDown)
        {
            direction = (direction == Direction.Right) ? Direction.Left : Direction.Right;
            var velocity = GetComponent<Rigidbody>().velocity;
            velocity.x = 0;
            velocity.z = 0;
            GetComponent<Rigidbody>().velocity = velocity; //y�� �����ߴ�. 
            //y�� ������ ���� �����ϸ鼭 �ٽ� ����.. 
            //y�� �߷��̶�!

            AddPoint(1);
        }

        BallMove();
    }

    public void AddPoint(int addPoint)
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
