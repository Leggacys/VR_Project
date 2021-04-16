using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private List<Transform> spawnPoints=new List<Transform>();
    public GameObject enemy;

    private void Awake()
    {
        foreach(Transform localTransform in transform)
        {
            spawnPoints.Add(localTransform);
        }
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            var spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count-1)];
            Instantiate(enemy, spawnPoint.position,spawnPoint.rotation);
        }
        
    }
    
}
