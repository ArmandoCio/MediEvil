using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
private void OnTriggerEnter(Collider other)
    
    {
        if (other.gameObject.CompareTag("Magic"))
        {
   
            Destroy(gameObject);
            Destroy(other.gameObject);
            gameManager.UpdateScore(35);

          

        }

    }
}
