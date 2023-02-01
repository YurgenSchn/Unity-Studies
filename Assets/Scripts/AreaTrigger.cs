using UnityEngine;

public class AreaTrigger : MonoBehaviour
{

    public EventObject eventReachedGround;

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject collider = other.gameObject;
        print("aoba");
        eventReachedGround.RaiseEvent(2f);
    }

}
