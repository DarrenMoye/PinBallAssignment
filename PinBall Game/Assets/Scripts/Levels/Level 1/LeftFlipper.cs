using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipper : MonoBehaviour
{
    [SerializeField]
    GameObject GO_Ball;

    [SerializeField]
    private float Force;

    [SerializeField]
    private Flipper1Controller _flipper1Controller;

    public float force
    {
        get { return Force; }
        set { Force = value; }
    }

    public float LeftTouchingBall
    {
        get { return _flipper1Controller.touchingBall; }
        set { _flipper1Controller.touchingBall = value; }
    }
        
    //void Start()
    //{
    //    RB = GetComponet<Rigidbody>(GO_Ball);
    //}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (LeftTouchingBall)
            {
                GO_Ball.GetComponent<Rigidbody>().velocity += new Vector3(0f, 0f, 0f);
                GO_Ball.GetComponent<Rigidbody>().AddForce(0f, force, 0f, ForceMode.Impulse);
            }

            for (int i = 0; i < 50; i++)
            {
                gameObject.transform.position += new Vector3(0f, 0.01f, 0f);
            }

        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            for (int i = 0; i < 5; i++)
                gameObject.transform.position += new Vector3(0f, -0.1f, 0f);
        }
    }
}
