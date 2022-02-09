using UnityEngine;

namespace CodeBase.Architecture.Stats
{
    public class StatsManager : MonoBehaviour
    {
        [SerializeField] private GameEvent _endGameEvent;
        [SerializeField] private int _lastGoal;
        
        private GameStats _gameStats;

        private void Awake() => _gameStats= new GameStats(_lastGoal,_endGameEvent);

        public void PlayerScore() => _gameStats.ScoreBy(Creature.Player);

        public void EnemyScore() => _gameStats.ScoreBy(Creature.Enemy);

        public void ResetStats() => _gameStats.ResetStats();

        public string GetWinnerName() => _gameStats.Winner;

        public string GetScore() => _gameStats.ToString();
    }
    public enum Creature
    {
        Player,
        Enemy
    }
}