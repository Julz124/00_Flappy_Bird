using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOffset = 1;
    
    void Start() {
        spawnPipe();
    }

    void Update() {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe() {
        float lowest = 0 - heightOffset;
        float highest = heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x,(Random.Range(lowest, highest) % 3), 0), transform.rotation);
    }
}
