using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject Item;
    
    //public Vector3 spawnPos[] = new Vector3[9];

    // Start is called before the first frame update
    void Start()
    {
        SpawnItem();
    }
    
    void SpawnItem()
    {
        int spawn = Random.Range(0, spawnPoints.Length);

        GameObject.Instantiate(Item, spawnPoints[spawn].transform.position, Quaternion.identity);
    }
}
