using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnlyZ : MonoBehaviour
{
    //카메라를 공의 자식으로 달아주고 원래 포지션의 y랑 x값을 기억해두고 z만 움직이게 한다. 

    public float x;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate() //움직이는 로직은 LateUpdate에서 해주는 게 좋다. 모든 업데이트가 실행이 된 이후에 움직여서 
        //Ball의 Update에서 move로 움직여주기 때문에 모든 업데이트문이 실행된 이후에 LateUpdate에서 카메라 포지션 움직이게 해줌.

    {
        var pos = transform.position;
        pos.x = x;
        pos.y = y;
        transform.position = pos;
        //x랑 y는 고정해주고 z만 움직이게 되는 구조

    }
}
