using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard : MonoBehaviour
{
    [SerializeField]
    private Flipper1Controller _flipper1Controller;

    public void OnButtonPressed()
    {
        _flipper1Controller.force = 30f;
    }
}
