using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleLeft : MonoBehaviour
{

    public static HingeJoint2D leftPaddle;
    public static JointMotor2D motor;

    // Use this for initialization
    void Start()
    {
        leftPaddle = gameObject.GetComponent<HingeJoint2D>();
        motor = leftPaddle.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            motor.motorSpeed = -5000;
            leftPaddle.useMotor = true;
            leftPaddle.motor = motor;
        }
        else
        {
            motor.motorSpeed = 0;
            leftPaddle.useMotor = false;
        }
    }
}
