using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jewel") == false)
            return;

        Destroy(other.gameObject);
        transform.parent.GetComponent<Ball>().AddPoint(2);
    }
}
