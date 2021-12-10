using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper1Controller : MonoBehaviour
{
    [SerializeField]
    GameObject GO_Ball;

    [SerializeField]
    private float ForceSoft;

    [SerializeField]
    private float ForceMedium;

    [SerializeField]
    private float ForceHard;

    private bool TouchingBall = false;

    public bool touchingBall
    {
        get { return TouchingBall; }
        set { TouchingBall = value; }
    }

    public float forceSoft
    {
        get { return ForceSoft; }
        set { ForceSoft = value; }
    }

    public float forceMedium
    {
        get { return ForceMedium; }
        set { ForceMedium = value; }
    }

    public float forceHard
    {
        get { return ForceHard; }
        set { ForceHard = value; }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (TouchingBall)
            {
                GO_Ball.GetComponent<Rigidbody>().AddForce(0f, forceSoft, 0f, ForceMode.Impulse);
            }

            for (int i = 0; i < 50; i++)
            { 
                gameObject.transform.position += new Vector3(0f, 0.01f, 0f);
            }

        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            for (int i = 0; i < 5; i++)
                gameObject.transform.position += new Vector3(0f, -0.1f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (TouchingBall)
            {
                GO_Ball.GetComponent<Rigidbody>().AddForce(0f, forceMedium, 0f, ForceMode.Impulse);
            }

            for (int i = 0; i < 50; i++)
            {
                gameObject.transform.position += new Vector3(0f, 0.01f, 0f);
            }

        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            for (int i = 0; i < 5; i++)
                gameObject.transform.position += new Vector3(0f, -0.1f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (TouchingBall)
            {
                GO_Ball.GetComponent<Rigidbody>().AddForce(0f, forceHard, 0f, ForceMode.Impulse);
            }

            for (int i = 0; i < 50; i++)
            {
                gameObject.transform.position += new Vector3(0f, 0.01f, 0f);
            }

        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            for (int i = 0; i < 5; i++)
                gameObject.transform.position += new Vector3(0f, -0.1f, 0f);
        }

    }
}
