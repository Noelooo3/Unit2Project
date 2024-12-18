using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform[] _enemySpawns;
    [SerializeField] private float _spawnInterval = 1.0f;
    public ScoreManager _scoreManager;
    
    // Maybe use an UnityEvent is better?
    public Action OnGameOverListener;
    
    void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void Start()
    {
        Spawn(_spawnInterval);
    }

    public void Spawn(float interval)
    {
        StartCoroutine(SpawnEnemies(interval));
    }

    private IEnumerator SpawnEnemies(float interval)
    {
        while (true)
        {
            Instantiate(_enemyPrefab, _enemySpawns[Random.Range(0, _enemySpawns.Length)].position, Quaternion.identity);
            yield return new WaitForSeconds(interval);
        }
    }

    public void GameOver()
    {
        _scoreManager.UpdateHighestScore();
        
        // if (OnGameOverListener != null)
        // {
        //     OnGameOverListener.Invoke();
        // }
        
        OnGameOverListener?.Invoke();
    }
}
