using UnityEngine;

public class AreaTrigger : MonoBehaviour
{

    public EventObject eventReachedGround;

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject collider = other.gameObject;

        if (collider.tag == "Player")
        {
            print("[Ground Area Collider] Player Collided.");
            print("[Ground Area Collider] Triggering the ReachedGroundEvent");
            print("[Ground Area Collider] A random float information was sent in the event");
            print("[Ground Area Collider] Self destroying...");
            eventReachedGround.RaiseEvent(2f);
            Destroy(gameObject);
        }
        
    }

}
