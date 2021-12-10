using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipper : MonoBehaviour
{
    [SerializeField]
    GameObject GO_Ball;

    [SerializeField]
    private float Force;

    private bool TouchingBallRight = false;

    public bool touchingBallRight
    {
        get { return TouchingBallRight; }
        set { TouchingBallRight = value; }
    }

    public float force
    {
        get { return Force; }
        set { Force = value; }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (TouchingBallRight)
            {
                GO_Ball.GetComponent<Rigidbody>().AddForce(force, force, 0f, ForceMode.Impulse);
            }

            for (int i = 0; i < 50; i++)
            {
                gameObject.transform.position += new Vector3(0.01f, 0.01f, 0f);
            }

        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            for (int i = 0; i < 5; i++)
                gameObject.transform.position += new Vector3(-0.1f, -0.1f, 0f);
        }
    }
}
