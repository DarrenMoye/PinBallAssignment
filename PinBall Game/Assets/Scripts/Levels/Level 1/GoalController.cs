using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    [SerializeField]
    private int Score;

    public int score
    {
        get { return Score; }
        set { Score = value; }
    }

    [SerializeField]
    GameObject GO_Ball;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == GO_Ball)
        {
            score++;

            GO_Ball.transform.position = new Vector3(10.5f, 6.3f, 0f);
        }
    }
}
