using UnityEngine;

public class ObjectAnimatorController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            animator.SetTrigger("ColorChange");

        if (Input.GetKeyDown(KeyCode.D))
            animator.SetTrigger("ScaleChange");

        if (Input.GetKeyDown(KeyCode.S))
            animator.SetTrigger("Spin");

        if (Input.GetKeyDown(KeyCode.W))
            animator.SetTrigger("Hover");
    }
}
