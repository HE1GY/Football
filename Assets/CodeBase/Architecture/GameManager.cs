using System;
using UnityEngine;

namespace CodeBase
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        public GameStats Stats{ get; private set; }
    
        public event Action StartGame, StopGame, ResetGame,EndGame;
        public event Action<Creature> ScoreGoal;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        private void Start()
        {
            Stats = new GameStats();
            ScoreGoal += Stats.RefreshStats;
            ResetGame += Stats.ResetStats;
        }

        private void OnDisable()
        {
            ScoreGoal -= Stats.RefreshStats;
            ResetGame -= Stats.ResetStats;
        }


        public void ToStartGame()
        {
            print("start");
            StartGame?.Invoke();
        }
        public void ToStopGame()
        {
            StopGame?.Invoke();
        }
        public void ToResetGame()
        {
            ResetGame?.Invoke();
        }
        public void ToScoreGoal(Creature scoreBy)
        {
            ScoreGoal?.Invoke(scoreBy);
        }
    }

    public enum Creature
    {
        Player,
        Enemy
    }
}
