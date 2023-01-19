using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Hexagon game object
    [Header("Shape Objects")]
    public GameObject[] shapePrefabs;
    //Spawn rate for how many
    //objects are spawned
    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 2f;
    [Header("Default Spawn Time")]
    public float  spawnTime = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }
    //Spawn function
    void Spawn()
    {
        int randomInt = Random.Range(0, shapePrefabs.Length);
        //Spawn new hexagon at position
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }
    //Game over function'
    public void GameOver()
    {
        CancelInvoke("Spawn");
    }
}
