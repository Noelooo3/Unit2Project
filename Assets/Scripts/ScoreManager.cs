using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public UnityEvent<int> _onScoreChanged = new UnityEvent<int>();

    private int _currentScore = 0;
    // Start is called before the first frame update
    public int CurrentScore
    {
        get => _currentScore;
        private set
        {
            _currentScore = value;
            _onScoreChanged?.Invoke(_currentScore);
        }
    }

    // Update is called once per frame
    public void AddScore(int points)
    {
        CurrentScore += points;
    }
}
