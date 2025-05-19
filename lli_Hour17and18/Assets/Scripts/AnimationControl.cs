using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Vertical")));
        anim.SetFloat("Direction", Input.GetAxis("Horizontal"));
    }
}

