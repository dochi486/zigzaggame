using UnityEngine;
using Random = UnityEngine.Random;

public class MapGenerator : MonoBehaviour
{
    public Transform cubeParent;
    public Cube baseItem;
    public int generateCount;
    public GameObject jewel;

    //큐브 랜덤하게 생성
    private void Awake()
    {
        GenerateCubes();
    }

    [ContextMenu("큐브생성")]
    private void GenerateCubes()
    {
        DestroyExistCube();
        //기존 블럭 파괴

        Vector3 previousPosition = Vector3.zero;

        for (int i = 0; i < generateCount; i++)
        {
            var newCube = Instantiate(baseItem, cubeParent);
            newCube.transform.localRotation = Quaternion.identity;

            previousPosition += Random.Range(0, 2) == 0 ? new Vector3(1, 0, 0) : new Vector3(0, 0, 1);
            //min은 포함이고 max는 포함 안된다. 그래서 0과 1만 나왔으면 할 때 0을 min 2를 max로 지정

            //if (Random.Range(0, 2) == 0)
            //    previousPosition += new Vector3(1, 0, 0);
            //else
            //    previousPosition += new Vector3(0, 0, 1);
            //삼항연산자 말고 if문으로하면 이렇게 된다. 

            newCube.transform.localPosition = previousPosition;
            previousPosition = newCube.transform.localPosition;

            if (Random.Range(0, 2) == 0)
            {
                //보석 배치 랜덤으로
                var newJewel = Instantiate(jewel);
                newJewel.transform.position = newCube.transform.position;
                float addY = newCube.transform.lossyScale.y * 0.5f;
                newJewel.transform.Translate(0, addY, 0, Space.World);
            }

        }
    }

    private void DestroyExistCube()
    {
        var allCube = cubeParent.GetComponentsInChildren<Cube>();
        foreach (var item in allCube)
        {
            DestroyImmediate(item.gameObject);
            //에디터에서도 Destroy하려면 일반 Destroy가 아니라 DestroyImmediate해줘야한다. 
        }
    }
}
