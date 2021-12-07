using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    Rigidbody Ball_Rigidbody;

    [SerializeField]
    private Flipper1Controller _flipper1Controller;

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == _flipper1Controller.gameObject)
        {
            _flipper1Controller.touchingBall = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == _flipper1Controller.gameObject)
        {
            _flipper1Controller.touchingBall = false;
        }
    }

    private void Start()
    {
        
    }
}
