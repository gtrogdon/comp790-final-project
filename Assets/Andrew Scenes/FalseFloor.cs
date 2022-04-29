using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseFloor : MonoBehaviour
{
    public GameObject tpSpot;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject obj = other.gameObject;
            obj.transform.position = tpSpot.transform.position;


        }
    }

}
