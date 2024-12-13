using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _inGameUI;
    [SerializeField] private GameObject _gameOverUI;
    
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private TextMeshProUGUI _scoreText;
    
    [SerializeField] private TextMeshProUGUI _highestScoreText;
    [SerializeField] private TextMeshProUGUI _finalScoreText;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        //listen and do
        Player.OnHealthChanged += UpdateHealth;
        if (GameManager._instance?._scoreManager != null)
        {
            GameManager._instance._scoreManager._onScoreChanged.AddListener(UpdateScore);
            GameManager._instance.OnGameOver += OnGameOver;
        }
    }

    // Update is called once per frame
    void OnDisable()
    {
        //don't listen don't do 
        Player.OnHealthChanged -= UpdateHealth;
        GameManager._instance._scoreManager._onScoreChanged.RemoveListener(UpdateScore);
    }

    private void UpdateHealth(float health)
    {
        _healthText.text = "Health: " + health;
        Debug.Log("Health: " + health);
    }

    private void OnGameOver()
    {
        _finalScoreText.text = "Score: " + GameManager._instance._scoreManager.CurrentScore;
        
        _inGameUI.SetActive(false);
        _gameOverUI.SetActive(true);
    }
    
    public void UpdateScore(int score)
    {
        _scoreText.text = "Score: " + score;
    }

    public void UpdateHighestScore(int highestScore)
    {
        _highestScoreText.text = "Highest Score: " + highestScore;
    }
}
