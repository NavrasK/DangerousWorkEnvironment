using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawn : MonoBehaviour {
    [SerializeField]
    private GameObject[] chunks;

    void Start() {
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                //Color col = new Color(Random.value, Random.value, Random.value, 1.0f);
                GameObject o = Instantiate(chunks[Random.Range(0, chunks.Length)], new Vector3(i*10, 0, j*10), Quaternion.identity, this.transform);
                //o.GetComponent<MeshRenderer>().material.color = col;
            }
		}
    }

    void Update() {
        
    }
}
