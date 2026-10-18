using UnityEngine;

public class Car : MonoBehaviour
{
    private Rigidbody2D rb;

    private Vector3 movement;

    private void Start()
    {
        transform.position = new Vector3(Constants.carStartXPosition, Constants.carStartYPosition);
        rb = GetComponent<Rigidbody2D>();
        movement = Vector3.zero;
    }

    private void Update()
    {
        movement = Vector3.zero;
        rb.rotation = 0f;
        if (Input.GetKey(Constants.carLeftMovementKey))
        {
            movement = Vector3.left * Constants.carSpeed;
            rb.rotation = Constants.carMoveRotation;
        }

        if (Input.GetKey(Constants.carRightMovementKey))
        {
            movement = Vector3.right * Constants.carSpeed;
            rb.rotation = -Constants.carMoveRotation;
        }
        rb.linearVelocity = movement;
    }

    private void FixedUpdate()
    {
    }
}
