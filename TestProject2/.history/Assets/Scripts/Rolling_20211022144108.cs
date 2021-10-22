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
        var movement2 = new Vector3(0,0,0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 movement2 = new Vector3(movementHorizontal, 2, movementVertical);
        }
        rb.AddForce(movement * speed);
        rb.AddForce(movement2 * speed);
    }
}
