using UnityEngine;

public class GameTimer : MonoBehaviour
{
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), "Time: " + timer.ToString("F2"));
    }
}
