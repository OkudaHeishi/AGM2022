using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D rb ;
    private Vector2 playerDir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float axisY = Input.GetAxisRaw("Vertical");
        playerDir = new Vector2(0,axisY).normalized;        
    }
    void FixedUpdate(){
        rb.velocity = new Vector2(0,playerDir.y * playerSpeed);
    }
}
