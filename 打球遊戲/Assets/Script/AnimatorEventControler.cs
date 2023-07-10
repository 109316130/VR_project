using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorEventControler : MonoBehaviour
{
    public Rigidbody ball;
    public GameObject startPoint;
    float force = 40f;
    // Start is called before the first frame update
    public void ThrowBall()
    {
        ball.transform.position = startPoint.transform.position;
        ball.AddForce(Vector3.back * force, ForceMode.Impulse);
    }
}
