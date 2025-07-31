using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameObject fullnessBar;
    private SliderScript sliderScript;
    public TextMeshProUGUI scoreText; 
    private int score;
    private int fullness;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sliderScript = fullnessBar.GetComponent<SliderScript>();
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

    public void AddToFullness(float points)
    {
        sliderScript.AddProgress(points);
    }
}
