using UnityEngine;
using Random = UnityEngine.Random;

public class MapGenerator : MonoBehaviour
{
    public Transform cubeParent;
    public Cube baseItem;
    public int generateCount;
    public GameObject jewel;

    //ť�� �����ϰ� ����
    private void Awake()
    {
        GenerateCubes();
    }

    [ContextMenu("ť�����")]
    private void GenerateCubes()
    {
        DestroyExistCube();
        //���� �� �ı�

        Vector3 previousPosition = Vector3.zero;

        for (int i = 0; i < generateCount; i++)
        {
            var newCube = Instantiate(baseItem, cubeParent);
            newCube.transform.localRotation = Quaternion.identity;

            previousPosition += Random.Range(0, 2) == 0 ? new Vector3(1, 0, 0) : new Vector3(0, 0, 1);
            //min�� �����̰� max�� ���� �ȵȴ�. �׷��� 0�� 1�� �������� �� �� 0�� min 2�� max�� ����

            //if (Random.Range(0, 2) == 0)
            //    previousPosition += new Vector3(1, 0, 0);
            //else
            //    previousPosition += new Vector3(0, 0, 1);
            //���׿����� ���� if�������ϸ� �̷��� �ȴ�. 

            newCube.transform.localPosition = previousPosition;
            previousPosition = newCube.transform.localPosition;

            if (Random.Range(0, 2) == 0)
            {
                //���� ��ġ ��������
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
            //�����Ϳ����� Destroy�Ϸ��� �Ϲ� Destroy�� �ƴ϶� DestroyImmediate������Ѵ�. 
        }
    }
}
