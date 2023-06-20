using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    public void FixedUpdate()
    {
        if (ball.velocity.x > 0f) //ball is moving towards computer paddle
        {
            if (ball.position.y > rb.position.y)
            {
                rb.AddForce(Vector2.up * speed);
            }
            else if (ball.position.y < rb.position.y)
            {
                rb.AddForce(Vector2.down * speed);
            }
        }
        else // ball is moving away from the computer paddle
        {
            if (rb.position.y > 0f)
            {
                rb.AddForce(Vector2.down * speed);
            }
            else if (rb.position.y < 0f) 
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
    }
}
