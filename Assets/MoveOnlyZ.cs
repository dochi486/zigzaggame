using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnlyZ : MonoBehaviour
{
    //ī�޶� ���� �ڽ����� �޾��ְ� ���� �������� y�� x���� ����صΰ� z�� �����̰� �Ѵ�. 

    public float x;
    public float y;
    Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        rotation = transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate() //�����̴� ������ LateUpdate���� ���ִ� �� ����. ��� ������Ʈ�� ������ �� ���Ŀ� �������� 
        //Ball�� Update���� move�� �������ֱ� ������ ��� ������Ʈ���� ����� ���Ŀ� LateUpdate���� ī�޶� ������ �����̰� ����.

    {
        var pos = transform.position;
        pos.x = x;
        pos.y = y;
        transform.position = pos;

        transform.rotation = rotation;
        //x�� y�� �������ְ� z�� �����̰� �Ǵ� ����

    }
}
