using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathFloor : MonoBehaviour
{
    [SerializeField]
    private int Lives = 5;

    public int lives
    {
        get { return Lives; }
        set { Lives = value; }
    }

    [SerializeField]
    GameObject GO_Ball;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == GO_Ball)
        {
            lives--;
            GO_Ball.transform.position = new Vector3(10.5f, 6.3f, 0f);
        }
    }

    public void Update()
    {
        if (Lives <= 0)
        {
            SceneManager.LoadScene("Death Message");
        }
    }
}
