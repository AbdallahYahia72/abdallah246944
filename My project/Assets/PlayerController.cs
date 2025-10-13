using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;     // how fast the character moves
    public float jumpHeight;    // how high the character jumps

    public KeyCode Spacebar;    // Jump key (e.g., Space)
    public KeyCode L;           // Left movement key
    public KeyCode R;           // Right movement key

    void Update()
    {
        // Jump when pressing Spacebar
        if (Input.GetKeyDown(Spacebar))
        {
            Jump();
        }

        // Move Left
        if (Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

            // Flip sprite to face left
            if (GetComponent<SpriteRenderer>() != null)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
        }

        // Move Right
        if (Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

            // Flip sprite to face right
            if (GetComponent<SpriteRenderer>() != null)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
}
