using UnityEngine.Events;
using UnityEngine;

public abstract class EventGeneric<T> : ScriptableObject
{
    public UnityAction<T> OnEventRaised;

    public void RaiseEvent(T value)
    {
        OnEventRaised?.Invoke(value);
    }

}
