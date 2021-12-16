using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipper : MonoBehaviour
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

    private bool RightTouchingball = false;
    public bool RightTouchingBall
    {
        get { return RightTouchingball; }
        set { RightTouchingball = value; }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (RightTouchingball)
            {
                GO_Ball.GetComponent<Rigidbody>().velocity += new Vector3(0f, 0f, 0f);
                GO_Ball.GetComponent<Rigidbody>().AddForce(-1f, force, 0f, ForceMode.Impulse);
            }

            for (int i = 0; i < 50; i++)
            {
                gameObject.transform.position += new Vector3(0f, 0.01f, 0f);
            }

        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            for (int i = 0; i < 5; i++)
                gameObject.transform.position += new Vector3(0f, -0.1f, 0f);
        }
    }
}
