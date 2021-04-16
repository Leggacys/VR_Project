using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    #region
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public int timeBetweenWeaves;
    public int numbersOfSpawns;
    public GameObject cube;
    public Transform[] spawnPoints;
    public int timeBeetwenSpawn;
    private float time;

    private void Start()
    {
        StartCoroutine(HardMode());
    }

    public void Update()
    {
        if(time+timeBetweenWeaves<Time.time)
        {
            time = Time.time;
            StartCoroutine(SPAWN()); 
        }
    }

    IEnumerator SPAWN()
    {
        for (int index = 0; index < numbersOfSpawns; index++)
        {
            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length-1)];
            Instantiate(cube, spawn.position, spawn.rotation);
            yield return new WaitForSeconds(timeBeetwenSpawn);
        }
    }

    public void Reset()
    {
        Application.LoadLevel(Application.loadedLevel);
    }


    IEnumerator HardMode()
    {
        yield return new WaitForSeconds(40);
        numbersOfSpawns = 9;
        timeBeetwenSpawn = 2;
        timeBetweenWeaves = 3;

        StartCoroutine(EpicMode());
    }

    IEnumerator EpicMode()
    {
        yield return new WaitForSeconds(100);

        numbersOfSpawns = 19;
        timeBeetwenSpawn = 1;
        timeBetweenWeaves = 4;

    }
}
