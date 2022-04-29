using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedestalTrigger : MonoBehaviour
{

    public int number;
    public GameObject pedestal;
    public CypherState stateTracker;

   //public float x, y, z;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Letter")
        {
            GameObject obj = other.gameObject;
            obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
            obj.transform.position = pedestal.transform.position + new Vector3(0, 2.4f, 0);//new Vector3(0, 2.7f, 0.2f);
            obj.transform.eulerAngles = new Vector3(-65,0,0);

            char val = obj.name[0];
            stateTracker.putChar(val, number);

        }
    }
}