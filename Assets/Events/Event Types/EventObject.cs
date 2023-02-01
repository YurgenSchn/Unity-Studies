using UnityEngine;

[CreateAssetMenu(menuName = "Event/Object")]
public class EventObject : EventGeneric<object> { }

// Concretiza a classe abstrata, passando o tipo do evento