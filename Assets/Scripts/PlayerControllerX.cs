using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject Magic;
    public float horizontalInput;
    public float speed = 5.0f;
    private GameManager gameManager;


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
            // On spacebar press fire dmg
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(Magic, transform.position, Magic.transform.rotation);
            }
        }

    }
    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.CompareTag("Magic"))
        {

            
            Destroy(other.gameObject);
            
            
        }



    }
}
