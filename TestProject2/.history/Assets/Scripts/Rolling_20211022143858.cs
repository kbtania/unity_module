using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{
    public float speed = 2.5f;
    private Rigidbody rb;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementVertical);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(movementHorizontal, jumpForce, movementVertical);
        }
        rb.AddForce(movement * speed);
    }
}
