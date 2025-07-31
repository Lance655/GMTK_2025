using UnityEngine;

public class SelectRandomFood : MonoBehaviour
{
    public GameObject[] foodList;
    private float rightBound = 11.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform sushiParent = transform.Find("Sushi");
        int index = Random.Range(0, foodList.Length);
        Instantiate(foodList[index], sushiParent.transform.position, sushiParent.transform.rotation, sushiParent);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}
