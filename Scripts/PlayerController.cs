using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.isKinematic = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 force = new Vector2(moveX, moveY);
        Vector2 now = rb2d.position;
        now += force;
        rb2d.position = now;
        // rb2d.AddForce(force * 10);
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 100) * Time.deltaTime);
    }
}

