using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float jumpForce;
    public float moveForce;
    public GameObject GameManager;
    public GameOver GameOver;
    private int score;


    private Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        score = 0;
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
        }

        if(Input.GetMouseButtonDown(1)){
            myRigidbody.velocity = new Vector2(moveForce, myRigidbody.velocity.y);
        }
    }

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Friend")){
		GameOver.setup(score);
            Destroy(gameObject);
        }

        else if(other.gameObject.CompareTag("Riches")){
		score++;
            Destroy(other.gameObject);
        }
    }
}
