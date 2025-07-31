using UnityEngine;
using System.Collections;

public class SushiSpawner : MonoBehaviour
{
    public GameObject[] sushiList;
    public float spawnRate = 2.5f;
    private float spawnX = -10f;
    private float spawnY = 0.6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("spawnSushi");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawnSushi()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, sushiList.Length);
            Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);

            Instantiate(sushiList[index], spawnPos, sushiList[index].transform.rotation);
        }
    }
}
