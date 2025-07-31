using UnityEngine;
using System.Collections;

public class ItemSpawner : MonoBehaviour
{
    public GameObject item;
    public float spawnRate = 2.5f;
    private float spawnX = -10f;
    private float spawnY = -1.5f;
    private float spawnXFast = 11.0f;
    private float spawnYFast = 2.7f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("spawnItem");
        StartCoroutine("spawnItemFast");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawnItem()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);

            Instantiate(item, spawnPos, item.transform.rotation);
        }
    }

    IEnumerator spawnItemFast()
    {
        while (true)
        {
            float spawnRateFast = Random.Range(10.0f, 30.0f);

            yield return new WaitForSeconds(spawnRateFast);
            Vector3 spawnPos = new Vector3(spawnXFast, spawnYFast, 0);

            GameObject itemFast = Instantiate(item, spawnPos, item.transform.rotation);
            itemFast.GetComponent<MoveItem>().goingLeft = true;
        }
    }
}
