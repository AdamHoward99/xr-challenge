using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI ScoreTxt;
    private static int Score = 0;

    public static void UpdateScore(int amount)
    {
        Score += amount;
    }

    public void ShowScore()
    {
        ScoreTxt.text = "Score: " + Score;
    }

    private void Update()
    {
        ShowScore();
    }

}
