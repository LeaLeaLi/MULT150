using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = 0.5f;
    private Renderer renderer;
    private float offset;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        offset += Time.deltaTime * speed;
        if (offset > 1) offset -= 1;
        renderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}
