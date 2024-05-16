using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PipeScript : MonoBehaviour{

    public float moveSpeed = 5;
    public float deadzone = -20;
    
    void Start(){
        
    }

    void Update(){
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;        

        if (transform.position.x < deadzone) {
            Destroy(gameObject);
        }
    }
}
