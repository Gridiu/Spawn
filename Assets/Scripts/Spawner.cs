using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _points;
    [SerializeField] private GameObject _prefab;

    private Transform[] _spawnPoints;
    private int _currentPointIndex;

    private void Start()
    {
        _spawnPoints = new Transform[_points.childCount];

        for (int i = 0; i < _points.childCount; i++)
        {
            _spawnPoints[i] = _points.GetChild(i);
        }
    }

    public void SpawnEnemy()
    {
        int firstPointIndex = 0;

        Instantiate(_prefab, _spawnPoints[_currentPointIndex].transform);

        _currentPointIndex++;

        if (_currentPointIndex == _spawnPoints.Length)
        {
            _currentPointIndex = firstPointIndex;
        }
    }
}
