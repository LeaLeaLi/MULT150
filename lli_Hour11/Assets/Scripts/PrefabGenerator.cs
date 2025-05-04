using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPosition = new Vector3(i * 3f, 0f, 0f);
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
