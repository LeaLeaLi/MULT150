using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager manager;
    public Material normalMat;
    public Material phasedMat;
    public float bounds = 3f;
    public float strafeSpeed = 4f;
    public float phaseCooldown = 2f;

    Renderer mesh;
    Collider collision;
    bool canPhase = true;

    void Start()
    {
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();
        collision = GetComponent<Collider>();
    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed;
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x + xMove, -bounds, bounds);
        transform.position = position;

        if (Input.GetButtonDown("Jump") && canPhase)
        {
            canPhase = false;
            mesh.material = phasedMat;
            collision.enabled = false;
            Invoke("PhaseIn", phaseCooldown);
        }
    }

    void PhaseIn()
    {
        canPhase = true;
        mesh.material = normalMat;
        collision.enabled = true;
    }
}
