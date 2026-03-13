using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 vel;
    public Transform floorCollider;
    public float moveSpeed = 5f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        vel = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && floorCollider.GetComponent<FloorCollider>(). canJump == true)
        {

            rb.velocity = Vector2.zero;
            floorCollider.GetComponent<FloorCollider>().canJump = false;
            rb.AddForce(new Vector2(0, 400));

        }
    }

    private void FixedUpdate()
    {
        rb.velocity = vel;
    }
}
