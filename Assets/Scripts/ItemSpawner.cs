using UnityEngine;
using System.Collections;

public class ItemSpawner : MonoBehaviour
{
    public GameObject item;
    public float spawnRate = 2.5f;
    private float spawnX = -10f;
    private float spawnY = 0.6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("spawnItem");
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
}
