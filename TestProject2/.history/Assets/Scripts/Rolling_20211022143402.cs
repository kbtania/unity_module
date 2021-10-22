using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{
    public float speed = 2.5f;
    private Rigidbody rb;
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
        float curr = 0.0f;

        Vector3 movement = new Vector3(movementHorizontal, curr+=1, movementVertical);

        rb.AddForce(movement * speed);
    }
}
