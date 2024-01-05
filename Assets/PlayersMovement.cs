using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float movementSpeed = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(movementSpeed * Time.deltaTime, 0, 0);
        }
    }
}
