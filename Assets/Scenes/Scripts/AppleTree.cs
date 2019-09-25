using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{

    [Header("Set in Inspector")]

    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;

    void Start()
    {
        // Dropping apples every second
        Invoke("DropApple", 1.5f);                                      // a
    }

    void DropApple()
    {                                                  // b
        GameObject apple = Instantiate<GameObject>(applePrefab);      // c
        apple.transform.position = transform.position;                  // d
        Invoke("DropApple", secondsBetweenAppleDrops);                // e
    }

    void Update()
    {
        {
            // Basic Movement
            Vector3 pos = transform.position;                 // b
            pos.x += speed * Time.deltaTime;                  // c
            transform.position = pos;                         // d

            // Changing Direction
            if (pos.x < -leftAndRightEdge)
            {
                speed = Mathf.Abs(speed); // Move right
            }
            else if (pos.x > leftAndRightEdge)
            {
                speed = -Mathf.Abs(speed); // Move left
            }
            else if (Random.value < chanceToChangeDirections)
            {        // a
                speed *= -1; // Change direction                          // b
            }
        }
    }
}