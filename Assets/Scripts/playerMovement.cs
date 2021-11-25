using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce = 30f;
    public float forwardForce = 4f;

    bool spacePressed = false, wPressed = false, sPressed = false;

    private void Update()
    {
        if (Input.GetKey("space"))
        {
            spacePressed = true;
        }
        else
        {
            spacePressed = false;
        }
        if (Input.GetKeyDown("w"))
        {
            wPressed = true;
        }
        else
        {
            wPressed = false;
        }
        if (Input.GetKeyDown("s"))
        {
            sPressed = true;
        }
        else
        {
            sPressed = false;
        }
    }
    void FixedUpdate()
    {
        if (spacePressed) { Jump(); }
        if (wPressed) { Forward(); }
        if (sPressed) { Backward(); }
    }
    void Jump()
    {
        rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
    }

    void Forward()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
    }

    void Backward()
    {
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
    }

}
