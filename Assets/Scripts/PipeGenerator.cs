using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    [Header("Pipe")]
    [SerializeField] GameObject pipePrefab;

    [Header("Pipe Spawn Time")]
    [SerializeField] float minTimeBetweenSpawns = 1f;
    [SerializeField] float maxTimeBetweenSpawns = 3f;

    [Header("Pipe Spawn Height")]
    [SerializeField] float maxSpawnHeight = 0.6f;
    [SerializeField] float minSpawnHeight = -1.3f;

    private void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    IEnumerator SpawnPipes()
    {
        while (true)
        {
            float spawnHeight = Random.Range(minSpawnHeight, maxSpawnHeight);
            Vector3 spawnTransform = new Vector3 (transform.position.x, spawnHeight, transform.position.z);

            Instantiate(pipePrefab, spawnTransform, Quaternion.identity, transform);

            yield return new WaitForSecondsRealtime(Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns));
        }
    }
}
