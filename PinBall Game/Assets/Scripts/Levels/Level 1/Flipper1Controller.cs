using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper1Controller : MonoBehaviour
{
    [SerializeField]
    GameObject GO_Ball;

    [SerializeField]
    private float Force;

    private bool TouchingBall = false;

    public bool touchingBall
    {
        get { return TouchingBall; }
        set { TouchingBall = value; }
    }

    public float force
    {
        get { return Force; }
        set { Force = value; }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (TouchingBall)
            {
                GO_Ball.GetComponent<Rigidbody>().AddForce(0f, force, 0f, ForceMode.Impulse);
            }

            for (int i = 0; i < 50; i++)
            { 
                gameObject.transform.position += new Vector3(0f, 0.01f, 0f);
            }

        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            for (int i = 0; i < 5; i++)
                gameObject.transform.position += new Vector3(0f, -0.1f, 0f);
        }

    }
}
