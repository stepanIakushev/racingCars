using UnityEngine;

public class Car : MonoBehaviour
{
    Vector3 movement;

    void Start()
    {
        transform.position = new Vector3(Constants.carStartXPosition, Constants.carStartYPosition);
        movement = Vector2.zero;
    }

    private void FixedUpdate()
    {
        movement = Vector2.zero;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetKey(Constants.carLeftMovementKey))
        {
            movement = new Vector3(-(Constants.carSpeed * Time.fixedDeltaTime), 0);
            transform.rotation = Quaternion.Euler(0, 0, 30);
        }
        if (Input.GetKey(Constants.carRightMovementKey))
        {
            movement = new Vector3(Constants.carSpeed * Time.fixedDeltaTime, 0);
            transform.rotation = Quaternion.Euler(0, 0, -30);
        }

        transform.position += movement;
    }

    void Update()
    {

    }
}
