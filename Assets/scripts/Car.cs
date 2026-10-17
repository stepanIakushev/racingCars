using UnityEngine;

public class Car : MonoBehaviour
{
    Vector3 movement;

    void Start()
    {
        transform.position = new Vector3(Constants.carStartXPosition, Constants.carStartYPosition);
        movement = Vector2.zero;
    }

    void Update()
    {
        movement = Vector2.zero;
        if (Input.GetKey(Constants.carLeftMovementKey))
        {
            movement = new Vector3(-(Constants.carSpeed * Time.deltaTime), 0);
        }

        if (Input.GetKey(Constants.carRightMovementKey))
        {
            movement = new Vector3(Constants.carSpeed * Time.deltaTime, 0);
        }

        transform.position += movement;
    }
}
