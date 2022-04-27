using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Enemy _prefab;
    [SerializeField] private float _secondBetweenSpawn;

    private float _elapsedTime = 0;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _secondBetweenSpawn)
        {
            _elapsedTime = 0;

            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(_prefab, _spawnPoints[spawnPointNumber]);
        }
    }
}
