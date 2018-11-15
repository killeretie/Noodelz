using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody2D rb;

    public float sidewaysForce = 50f;  // Variable that determines the sideways force
    public float maxSpeed = 15f;

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {

        if (Input.GetKey("d"))  // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(transform.right * sidewaysForce);
        }

        if (Input.GetKey("a"))  // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-transform.right * sidewaysForce);
        }

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
        }
    }

}