using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pmovement : MonoBehaviour
{
    private Controls controls;
    Framework fw;
    // Start is called before the first frame update
    void Start()
    {
        controls = GetComponent<Controls>();
        fw = GetComponent<Framework>();
        controls._input.PlayerGameplay.Enable();
        controls._input.PlayerGameplay.Move.performed += MovePerformed;
        controls._input.PlayerGameplay.Move.canceled += MoveCanceled;
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
        if (fw.speed < fw.maxspeed & controls._input.PlayerGameplay.Move.ReadValue<Vector2>() != Vector2.zero)
        {
            fw.speed += fw.acceleration * Time.deltaTime;
        }

    }

    private void FixedUpdate()
    {
        Debug.Log(controls._input.PlayerGameplay.Move.ReadValue<Vector2>());
        fw.rb.velocity = controls._input.PlayerGameplay.Move.ReadValue<Vector2>() * fw.speed * Time.deltaTime;
    }

}
