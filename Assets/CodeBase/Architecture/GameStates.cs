namespace CodeBase
{
    public class GameStats
    {
        public int PlayerGoalCount { get; set; }
        public int EnemyGoalCount { get; set; }

        public void RefreshStats(Creature creature)
        {
            if (creature == Creature.Enemy)
            {
                EnemyGoalCount++;
            }
            else
            {
                PlayerGoalCount++;
            }
        }

        public void ResetStats()
        {
            PlayerGoalCount = default(int);
            EnemyGoalCount = default(int);
        }
    }
}