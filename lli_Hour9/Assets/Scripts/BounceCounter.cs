using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int bounceCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerSphere")
        {
            bounceCount++;
            Debug.Log("Bounce Count: " + bounceCount);
        }
    }
}
