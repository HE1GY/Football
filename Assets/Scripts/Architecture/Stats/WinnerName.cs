using System.Collections;
using System.Collections.Generic;
using CodeBase.Architecture.Stats;
using UnityEngine;
using UnityEngine.UI;

public class WinnerName : MonoBehaviour
{
   [SerializeField] private StatsManager _statsManager;
   [SerializeField] private Text _nameText;


   public void SetWinnerName() => _nameText.text = _statsManager.GetWinnerName()+" Win";

}
