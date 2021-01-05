using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 2;
    float moveX = 0;
    float moveY = 0;
    bool facingRight = true; 
    public Rigidbody2D body;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        moveX = Input.GetAxisRaw("Horizontal");
        moveY = body.velocity.y;

        body.velocity = new Vector2(moveX * speed, moveY);

        Jump();
    }

    void LateUpdate()
    {
        //Move the character
  
        Vector3 scale = transform.localScale;

        if (moveX > 0)
        {
            facingRight = true;
        }
        else if(moveX < 0)
        {
            facingRight = false;
        }

        if((facingRight && (scale.x < 0)) || (!facingRight) && scale.x > 0 )
        {
            scale.x *= -1;
        }
        transform.localScale = scale;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }
}
