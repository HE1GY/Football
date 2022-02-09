using System;
using System.Collections;
using System.Collections.Generic;
using CodeBase.Architecture;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIButton : MonoBehaviour
{
     [SerializeField] private GameEvent _gameEvent;

    public void InvokeGameEvent()
    {
        _gameEvent.Invoke();
    }
}
