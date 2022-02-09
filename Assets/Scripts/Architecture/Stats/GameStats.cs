namespace CodeBase.Architecture.Stats
{
    public class GameStats
    {
        private readonly int _goalsToWin;
        private readonly GameEvent _endGameEvent;
        
        public string Winner { get; private set; }
        
        private int _playerGoalCount;
        private int _enemyGoalCount;

        public GameStats(int goalsToWin,GameEvent endGameEvent)
        {
            _goalsToWin = goalsToWin;
            _endGameEvent = endGameEvent;
        }

        public override string ToString()
        {
            return $"{_playerGoalCount}-{_enemyGoalCount}";
        }

        public void ScoreBy(Creature creature)
        {
            if (creature == Creature.Enemy)
            {
               var currentPoint= ++_enemyGoalCount;
                CheckIfWin(currentPoint,creature);
            }
            else
            {
                var currentPoint= ++_playerGoalCount;
                CheckIfWin(currentPoint,creature);
            }
        }

        public void ResetStats()
        {
            _playerGoalCount = default(int);
            _enemyGoalCount = default(int);
        }

        private void CheckIfWin(int score,Creature creature)
        {
            if (score > _goalsToWin)
            {
                Winner = creature.ToString();
                _endGameEvent.Invoke();
            }
        }
    }
}