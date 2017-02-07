using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleRight : MonoBehaviour {

    public static HingeJoint2D rightPaddle;
    public static JointMotor2D motor;

    // Use this for initialization
    void Start ()
    {
        rightPaddle = gameObject.GetComponent<HingeJoint2D>();
        motor = rightPaddle.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            motor.motorSpeed = 5000;
            rightPaddle.useMotor = true;
            rightPaddle.motor = motor;
        }
        else
        {
            motor.motorSpeed = 0;
            rightPaddle.useMotor = false;
        }
    }
}
