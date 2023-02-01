using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public EventObject eventReachedGround;

    void Start()
    {
        eventReachedGround.OnEventRaised += gritar;
    }

    void gritar(object a)
    {
        print("Aah vou cair " + a.ToString());
    }

}
