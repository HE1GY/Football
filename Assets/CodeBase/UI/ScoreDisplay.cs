using System;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI
{
    public class ScoreDisplay : MonoBehaviour
    {
        private Text _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<Text>();
        }

        private void Start()
        {
            GameManager.Instance.ScoreGoal += OnGoalScore;
        }

        private void OnGoalScore(Creature creatureWhoScore)
        {
            _scoreText.text = $"{GameManager.Instance.Stats.PlayerGoalCount}-{GameManager.Instance.Stats.EnemyGoalCount}";
        }
    }
}
