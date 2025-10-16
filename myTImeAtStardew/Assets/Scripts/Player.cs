using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayerCamera cam;
    [SerializeField] Transform playerPos;
    [SerializeField] InputActionAsset playerActions;

    InputAction move;
    InputAction jump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        move = playerActions.FindActionMap("Keyboard").FindAction("Move");
        jump= playerActions.FindActionMap("Keyboard").FindAction("Jump");

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveValue = move.ReadValue<Vector2>(); // supposed to read the movement input and tell which key is being pressed.
        //Debug.Log(moveValue);

        if (jump.IsPressed())
        {
            Debug.Log("Jump");
        }
        
    }


}
