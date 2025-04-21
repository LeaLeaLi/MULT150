using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " entered " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name + " stays in " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " exited " + gameObject.name);
    }
}
