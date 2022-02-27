using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    public float speed = 7f;
    private Vector3 startPosition;

    void Start(){
        startPosition = transform.position;;
    }

    void Update(){
        transform.Translate(Vector3.left * speed* Time.deltaTime);
        
    }
}
