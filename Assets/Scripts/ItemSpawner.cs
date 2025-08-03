using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class SushiSet
{
    public GameObject signPlate;
    public List<GameObject> ItemPrefabs;
}

public class ItemSpawner : MonoBehaviour
{
    public List<SushiSet> sushiSets;
    public List<GameObject> singleSushiList;  // For random singles
    public GameObject item;
    public GameObject topConveyorBelt;
    public float spawnInterval = 2.5f;

    // private float spawnX = -10f;
    // private float spawnY = 0.84f;
    private float spawnXFast = 11.0f;
    private float spawnYFast = 2.7f;

    private Vector3 spawnPos = new Vector3(-10f, 0.84f, 0); // copied position from spawnX, spawnY

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("SpawnRoutine");
        StartCoroutine("SpawnFastLane");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            // float coinFlip = Random.Range(0f, 1f);
            // if (coinFlip > 0.9)
            // {
            //     SpawnSinglePlate();
            // }
            // else
            // {
            //     yield return StartCoroutine(SpawnSushiSet()); // wait until the set is done before proceeding
            // }

            yield return StartCoroutine(SpawnSushiSet()); // wait until the set is done before proceeding
        }
    }


    IEnumerator SpawnFastLane()
    {
        while (true)
        {
            float spawnRateFast = Random.Range(5.0f, 15.0f);

            yield return new WaitForSeconds(spawnRateFast);
            Vector3 spawnPos = new Vector3(spawnXFast, spawnYFast, 0);

            GameObject itemFast = Instantiate(item, spawnPos, item.transform.rotation);
            itemFast.GetComponent<MoveItem>().goingLeft = true;

            // Run the "animation" only once:
            Debug.Log("spawned fast lane");
            if (topConveyorBelt == null)
                {
                    Debug.LogError("Top Conveyor Belt is not assigned in the inspector!");
                }
            else
                {
                    StartCoroutine(topConveyorBelt.GetComponent<ConveyorBelt>().RunTopConveyor());
                }
            // StartCoroutine(topConveyorBelt.GetComponent<ConveyorBelt>().RunTopConveyor());
            Debug.Log("called conveyor");
        }
    }

    IEnumerator SpawnSushiSet()
    {
        int index = Random.Range(0, sushiSets.Count);
        SushiSet chosenSet = sushiSets[index];

        // spawn sign plate first
        Instantiate(chosenSet.signPlate, spawnPos, chosenSet.signPlate.transform.rotation);
        yield return new WaitForSeconds(2.5f); // delay before set

        // spawn the set of sushi
        foreach (GameObject itemPrefab in chosenSet.ItemPrefabs)
        {
            Instantiate(itemPrefab, spawnPos, itemPrefab.transform.rotation);
            yield return new WaitForSeconds(2.5f); // Short delay between plates
        }

    }

    void SpawnSinglePlate()
    {
        int index = Random.Range(0, singleSushiList.Count);
        GameObject singlePlate = singleSushiList[index];
        Instantiate(singlePlate, spawnPos, singlePlate.transform.rotation);
        Debug.Log("Special Item!");
    }
}
