using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    public PlayerActions _input;
    private void Start()
    {
        _input = new PlayerActions();
    }
}
