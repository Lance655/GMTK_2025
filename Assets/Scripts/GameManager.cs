using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set;}
    public TextMeshProUGUI scoreText;
    private int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // may have to incorporate duplciation prevention if multiple scenes
        Instance = this;
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddToScore(int points)
    {
        score += points;
        scoreText.text = "" + score;
    }
}
