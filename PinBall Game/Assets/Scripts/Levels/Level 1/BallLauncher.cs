using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField]
    private Flipper1Controller _flipper1Controller;

    [SerializeField]
    private LeftFlipper _LeftFlipperController;

    [SerializeField]
    private RightFlipper _RightFlipperController;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == _flipper1Controller.gameObject)
        {
            _flipper1Controller.touchingBall = true;
        }
        
        else if (collision.gameObject == _LeftFlipperController.gameObject)
        {
            _LeftFlipperController.LeftTouchingBall = true;
        }

        else if (collision.gameObject == _RightFlipperController.gameObject)
        {
            _RightFlipperController.RightTouchingBall = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == _flipper1Controller.gameObject)
        {
            _flipper1Controller.touchingBall = false;
        }
        
        else if (collision.gameObject == _LeftFlipperController.gameObject)
        {
            _LeftFlipperController.LeftTouchingBall = false;
        }

        else if (collision.gameObject == _RightFlipperController.gameObject)
        {
            _RightFlipperController.RightTouchingBall = false;
        }
    }
}
