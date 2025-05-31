using UnityEngine;

public class Velocity : MonoBehaviour
{
    public float startSpeed = 50f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Random.Range(-startSpeed, startSpeed), 0, Random.Range(-startSpeed, startSpeed));
    }
}
