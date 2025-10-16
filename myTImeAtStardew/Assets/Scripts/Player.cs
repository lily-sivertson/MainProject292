using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayerCamera cam;
    [SerializeField] Transform playerPos;
    [SerializeField] InputActionAsset playerActions;

    InputAction move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        move = playerActions.FindActionMap("Keyboard").FindAction("Move");

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveValue = move.ReadValue<Vector2>();
        Debug.Log(moveValue);
    }


}
