using System.Collections.Generic;
using UnityEngine;

namespace CodeBase.Architecture
{
    [CreateAssetMenu(menuName = "Game Events",fileName = "New Game Event",order = 51)]
    public class GameEvent:ScriptableObject
    {
        private HashSet<GameEventListener> _eventListeners=new HashSet<GameEventListener>();

        public void Invoke()
        {
            foreach (var eventListeners in _eventListeners)
            {
                eventListeners.OnEventRaised();
            }
        }
        public void RegisterListener(GameEventListener listener) => _eventListeners.Add(listener);
        public void UnregisterListener(GameEventListener listener) => _eventListeners.Remove(listener);

    }
}
