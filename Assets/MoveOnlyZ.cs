using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnlyZ : MonoBehaviour
{
    //ī�޶� ���� �ڽ����� �޾��ְ� ���� �������� y�� x���� ����صΰ� z�� �����̰� �Ѵ�. 

    public float x;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate() //�����̴� ������ LateUpdate���� ���ִ� �� ����. ��� ������Ʈ�� ������ �� ���Ŀ� �������� 
        //Ball�� Update���� move�� �������ֱ� ������ ��� ������Ʈ���� ����� ���Ŀ� LateUpdate���� ī�޶� ������ �����̰� ����.

    {
        var pos = transform.position;
        pos.x = x;
        pos.y = y;
        transform.position = pos;
        //x�� y�� �������ְ� z�� �����̰� �Ǵ� ����

    }
}
