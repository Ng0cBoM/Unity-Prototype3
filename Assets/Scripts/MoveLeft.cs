using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20;
    private PlayerController playerControllerScript;
    private float leftBound = -60;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && playerControllerScript.isGround ==true) speed = 50;
            if (Input.GetKeyUp(KeyCode.LeftShift) && playerControllerScript.isGround == true) speed = 20;
            
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
