using UnityEngine;

public class Food : MonoBehaviour
{
    public int points;
    public float fullPoints;
    public GameObject container;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (container == null)
        {
            Destroy(gameObject);
            GameManager.Instance.AddToScore(points);
        }
        else if (container.GetComponent<Container>().IsOpen)
        {
            Destroy(gameObject);
            GameManager.Instance.AddToScore(points);
            GameManager.Instance.AddToFullness(fullPoints);
        }
    }
}
