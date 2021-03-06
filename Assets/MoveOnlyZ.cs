using UnityEngine;

public class MoveOnlyZ : MonoBehaviour
{
    public Transform followTr;
    public Vector3 offset; //카메라랑 공 사이의 차이


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
    //카메라를 공의 자식으로 달아주고 원래 포지션의 y랑 x값을 기억해두고 z만 움직이게 한다. 

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
    //void LateUpdate() //움직이는 로직은 LateUpdate에서 해주는 게 좋다. 모든 업데이트가 실행이 된 이후에 움직여서 
    //    //Ball의 Update에서 move로 움직여주기 때문에 모든 업데이트문이 실행된 이후에 LateUpdate에서 카메라 포지션 움직이게 해줌.

    //{
    //    var pos = transform.position;
    //    pos.x = x;
    //    pos.y = y;
    //    transform.position = pos;

    //    transform.rotation = rotation;
    //    //x랑 y는 고정해주고 z만 움직이게 되는 구조

    //}
}
