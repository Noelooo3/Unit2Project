using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{

    public UnityEvent<int> _onScoreChanged = new UnityEvent<int>();
    public UnityEvent<int> _onHighestScoreUpdate = new UnityEvent<int>();

    private int _currentScore = 0;
    private int _highestScore = 0;

    private void Start()
    {
        HighestScore = PlayerPrefs.GetInt("DATA");

        //IF YOU WANT THE HIGHSCORE UI TO ALWAYS APPEAR, DO THIS:
        //UpdateHighestScore();
    }
    public void UpdateHighestScore()
    {
        if (CurrentScore > HighestScore)
        {
            //NEW HIGHEST SCORE!!!
            HighestScore = CurrentScore;

            //STORE HIGHEST SCORE IN A SAVE FILE
            PlayerPrefs.SetInt("DATA", HighestScore);

        }
    }

    public int CurrentScore
    {
        get => _currentScore;
        private set
        {
            _currentScore = value;
            _onScoreChanged?.Invoke(_currentScore);
        }
    }
    public int HighestScore
    {
        get => _highestScore;
        private set
        {
            _highestScore = value;
        }
    }
    // Update is called once per frame
    public void AddScore(int points)
    {
        CurrentScore += points;
    }


}
