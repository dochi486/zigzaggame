using UnityEngine;

public class MoveOnlyZ : MonoBehaviour
{
    public Transform followTr;
    public Vector3 offset; //ī�޶�� �� ������ ����


    private void Start()
    {
        offset = transform.position - followTr.position;
        x = transform.position.x;
        y = transform.position.y;
    }
    private void Update()
    {
        var pos = offset + followTr.position;
        pos.x = x;
        pos.y = y;
        transform.position = pos;
    }
    //ī�޶� ���� �ڽ����� �޾��ְ� ���� �������� y�� x���� ����صΰ� z�� �����̰� �Ѵ�. 

    public float x;
    public float y;
    //Quaternion rotation;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    x = transform.position.x;
    //    y = transform.position.y;
    //    rotation = transform.rotation;
    //}

    //// Update is called once per frame
    //void LateUpdate() //�����̴� ������ LateUpdate���� ���ִ� �� ����. ��� ������Ʈ�� ������ �� ���Ŀ� �������� 
    //    //Ball�� Update���� move�� �������ֱ� ������ ��� ������Ʈ���� ����� ���Ŀ� LateUpdate���� ī�޶� ������ �����̰� ����.

    //{
    //    var pos = transform.position;
    //    pos.x = x;
    //    pos.y = y;
    //    transform.position = pos;

    //    transform.rotation = rotation;
    //    //x�� y�� �������ְ� z�� �����̰� �Ǵ� ����

    //}
}
