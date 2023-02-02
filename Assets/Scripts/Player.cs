using UnityEngine;

public class Player : MonoBehaviour
{
    // This script will use an event, of type Object
    // Here, it will subscribe, and receive an Object
    public EventObject eventReachedGround;

    // Values for SmoothDamp
    private float currentLeftJoystickX;
    private float smoothLeftJoystickX;

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float joystickInputSmoothing;

    [SerializeField]
    private float playerSpeed;


    void Start()
    {
        eventReachedGround.OnEventRaised += reactToEvent;
    }

    // Subscriber to the ReachedGroundEvent
    void reactToEvent(object a)
    {
        print("[Player] This function was subscribed for the ReachedGroundEvent.");
        print("[Player] Here's what I received: " + a.ToString());
        print("[Player] Unsubscribing from the event.");
        eventReachedGround.OnEventRaised -= reactToEvent; //Once triggered, unsubscribe

    }

    void SmoothInput()
    {
        float horizontal = Input.GetAxis("LeftJoystickX");
        horizontal = Input.GetAxisRaw("Horizontal");
        currentLeftJoystickX = Mathf.SmoothDamp(currentLeftJoystickX, horizontal, ref smoothLeftJoystickX, joystickInputSmoothing);
    }

    void LateralMovement()
    {
        Vector2 currentVel = rb.velocity;
        currentVel.x = currentLeftJoystickX * playerSpeed;
        rb.velocity = currentVel;
    }

    void Update()
    {
        SmoothInput();
        LateralMovement();
    }

}
