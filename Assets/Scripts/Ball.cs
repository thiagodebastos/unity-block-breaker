using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // store reference to Paddle object
    public Paddle paddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;
    // Use this for initialization
    void Start()
    {
        // get difference between coordinates
        paddleToBallVector = this.transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            // lock Ball relative to Paddle
            this.transform.position = paddle.transform.position + paddleToBallVector;

            // wait for mousepress to launch
            if (Input.GetMouseButtonDown(0))
            {
                // prevent this code from running a second time
                hasStarted = true;
                // give Ball some velocity by accessing its RigidBody2D
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }
    }
}
