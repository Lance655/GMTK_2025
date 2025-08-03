using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ConveyorBelt : MonoBehaviour
{
    public bool top = false;
    public bool isBottom = false;
    public float rightSpeed = 0.7f;
    public float leftSpeed = 10f;
    private float bottoms_Offset = 12.46f; // from box collider
    private float tops_Offset = 12.49f; // from box collider

    private Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBottom == true)
        {
            if (transform.position.x >= startPos.x + bottoms_Offset)
            {
                transform.position = startPos;
            }

            transform.Translate(Vector3.right * rightSpeed * Time.deltaTime);
        }
        // else if (top == true)
        // {
        //     if (transform.position.x <= startPos.x - tops_Offset)
        //     {
        //         transform.position = startPos;
        //     }

        //     transform.Translate(Vector3.left * leftSpeed * Time.deltaTime);
        // }
    }

    // public void RunTopConveyor()
    // {
    //     while (transform.position.x > startPos.x - tops_Offset)
    //     {
    //         transform.Translate(Vector3.left * leftSpeed * Time.deltaTime);
    //     }
    //     transform.position = startPos;
    // }

    public IEnumerator RunTopConveyor()
    {

        for (int i = 0; i < 2; i++)
        {
            Vector3 resetPos = startPos;

            while (transform.position.x > startPos.x - tops_Offset)
            {
                transform.Translate(Vector3.left * leftSpeed * Time.deltaTime);
                yield return null; // Wait until next frame
            }

            transform.position = resetPos;
        }
    }

    
}
