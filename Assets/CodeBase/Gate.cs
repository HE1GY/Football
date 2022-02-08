using UnityEngine;
using UnityEngine.Serialization;

namespace CodeBase
{
    public class Gate : MonoBehaviour
    {
        [SerializeField] private Creature _creatureWhoScore;
        private void OnTriggerEnter(Collider other)
        {
            ScoreGoal();
        }

        private void ScoreGoal()
        {
           GameManager.Instance.ToScoreGoal(_creatureWhoScore);
        }
    }
}
