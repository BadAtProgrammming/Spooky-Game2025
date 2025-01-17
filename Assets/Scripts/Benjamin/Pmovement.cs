using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pmovement : MonoBehaviour
{
    public PlayerActions _input;
    Framework fw;

    public GameObject walking;
    [SerializeField] GameObject PlayerSprite;
    float SpriteRotation;

    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerActions();
        fw = GetComponent<Framework>();
        _input.PlayerGameplay.Enable();
        _input.PlayerGameplay.Move.performed += MovePerformed;
        _input.PlayerGameplay.Move.canceled += MoveCanceled;

        walking.SetActive(false);
    }

    void MovePerformed(InputAction.CallbackContext context)
    {
        Debug.Log("started moving");
        walking.SetActive(true);
    }

    void MoveCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("stopped moving");
        fw.speed = 0;
        walking.SetActive(false);
    }

    private void Update()
    {
        if (fw.speed < fw.maxspeed & _input.PlayerGameplay.Move.ReadValue<Vector2>() != Vector2.zero)
        {
            fw.speed += fw.acceleration * Time.deltaTime;
        }

        RotateSprite();

    }

    private void FixedUpdate()
    {
        fw.rb.velocity = _input.PlayerGameplay.Move.ReadValue<Vector2>() * fw.speed * Time.deltaTime;
    }

    private void RotateSprite() // this is pure horror. do not look beyond this point - benjamin
    {
        if (Input.GetKey(KeyCode.D))
        {
            PlayerSprite.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            PlayerSprite.transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            PlayerSprite.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            PlayerSprite.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        
    }

}
