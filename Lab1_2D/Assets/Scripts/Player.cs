using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int lives = 5;
    [SerializeField] private float jumpForce = 15f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = rb.GetComponent<SpriteRenderer>();
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        
        
    }
    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetButton("Horizontal"))
            Run();
        if(Input.GetKeyDown(KeyCode.Space))
            rb.AddForce (Vector3.up *3700);
    }

}
