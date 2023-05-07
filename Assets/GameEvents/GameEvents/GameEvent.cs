using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Events/New Game Event", fileName = "New Game Event")]
public class GameEvent : ScriptableObject
{
    private List<IGameEventListener> listeners = new List<IGameEventListener>();

    public void Fire()
    {
        for (int i = 0; i < listeners.Count; i++)
        {
            listeners[i].Notify();
        }
    }

    public void RegisterListener(IGameEventListener gameEventListener)
    {
        if (gameEventListener == null)
            return;
        if (listeners.Contains(gameEventListener))
            return;

        listeners.Add(gameEventListener);
    }

    public void UnregisterListener(IGameEventListener gameEventListener)
    {
        if (gameEventListener == null)
            return;
        if (listeners.Contains(gameEventListener) == false)
            return;

        listeners.Remove(gameEventListener);
    }
}
