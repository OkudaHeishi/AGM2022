using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFruit : MonoBehaviour
{
    public GameObject fruit;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

/*
    public float speed;
    private Vector3 startPosition;
    */
    
    // Update is called once per frame

    void Update()
    {
        if(Time.time >spawnTime){
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
        //transform.Translate(Vector3.left * speed * Time.deltaTime);
        
    }

    void Spawn(){
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(fruit, transform.position + new Vector3(randomX,randomY,0),transform.rotation);
        


    }
}
