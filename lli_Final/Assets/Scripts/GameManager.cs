using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Goal redGoal;
    public Goal blueGoal;
    public Goal greenGoal;
    public Goal orangeGoal;

    private bool isGameOver;

    void Update()
    {
        isGameOver = redGoal.isSolved && blueGoal.isSolved && greenGoal.isSolved && orangeGoal.isSolved;
    }

    void OnGUI()
    {
        if (isGameOver)
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "YOU WIN!");
        }
    }
}
