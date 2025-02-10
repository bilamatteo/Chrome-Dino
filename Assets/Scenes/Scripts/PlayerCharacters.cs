using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerCharacters : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpVelocity;
    public Vector2 direction;
    public float jumpHeight = 3f;
    public bool IsGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        IsGrounded = true;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        IsGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //jumpVelocity = RadQuad 2 * gravità
        
        if (IsGrounded && Input.GetKey(KeyCode.Space))
        {
            Jump();
        }

    }

    private void Jump()
    {
        jumpVelocity = Mathf.Sqrt(2f * Physics2D.gravity.magnitude * rb.gravityScale * jumpHeight);
        rb.velocity = Vector2.up * jumpVelocity;
        IsGrounded = false;
    }
}
