using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DistributorSpawners : MonoBehaviour
{
    private float _timeDelaySpawn = 2f;
    [SerializeField] private List<Spawner> _spawners;

    private void Start()
    {
        StartCoroutine(SpawnWithDelay());
    }

    private void SpawnInRandomSpawner()
    {
        int indexSpawner = Random.Range(0, _spawners.Count);
        _spawners[indexSpawner].Spawn();
    }

    private IEnumerator SpawnWithDelay()
    {
        bool isWorkCoroutine = true;

        while (isWorkCoroutine)
        {
            yield return new WaitForSeconds(_timeDelaySpawn);
            SpawnInRandomSpawner();
        }
    }
}
