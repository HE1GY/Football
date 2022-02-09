using System;
using CodeBase.Architecture.Stats;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace CodeBase.UI
{
    public class ScoreDisplay : MonoBehaviour
    {
        [SerializeField]private Text _scoreText;
        [SerializeField] private StatsManager statsManager;
        
        public void UpdateStats()
        {
            _scoreText.text = statsManager.GetScore();
        }
    }
}
