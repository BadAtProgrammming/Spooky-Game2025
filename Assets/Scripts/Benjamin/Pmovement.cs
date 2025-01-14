using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pmovement : MonoBehaviour
{
    public PlayerActions _input;
    Framework fw;
    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerActions();
        fw = GetComponent<Framework>();
        _input.PlayerGameplay.Enable();
        _input.PlayerGameplay.Move.performed += MovePerformed;
        _input.PlayerGameplay.Move.canceled += MoveCanceled;
    }

    void MovePerformed(InputAction.CallbackContext context)
    {
        Debug.Log("started moving");
    }

    void MoveCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("stopped moving");
        fw.speed = 0;
    }

    private void Update()
    {
        if (fw.speed < fw.maxspeed & _input.PlayerGameplay.Move.ReadValue<Vector2>() != Vector2.zero)
        {
            fw.speed += fw.acceleration * Time.deltaTime;
        }

    }

    private void FixedUpdate()
    {
        Debug.Log(_input.PlayerGameplay.Move.ReadValue<Vector2>());
        fw.rb.velocity = _input.PlayerGameplay.Move.ReadValue<Vector2>() * fw.speed * Time.deltaTime;
    }

}
