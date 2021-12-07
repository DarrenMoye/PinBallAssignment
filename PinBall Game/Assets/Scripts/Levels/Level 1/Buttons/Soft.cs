using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soft : MonoBehaviour
{
    [SerializeField]
    private Flipper1Controller _flipper1Controller;
    
    public void OnButtonPressed()
    {
        _flipper1Controller.force = 10f;
    }
}
