using CodeBase.Architecture;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeBase
{
    public class Gate : MonoBehaviour
    {
        [SerializeField] private GameEvent _scoreGoal;
        private void OnTriggerEnter(Collider other)
        {
            ScoreGoal();
        }

        private void ScoreGoal()
        {
            _scoreGoal.Invoke();
        }
    }
}
