using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsEnemy : MonoBehaviour
{
    private float leftLimit = -9f;
    private GameManager gameManager;


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        // Destroy enemy if past z position
        if (transform.position.z < leftLimit)
        {
            gameManager.GameOver();
            Destroy(gameObject);
            



        }

    }
}
