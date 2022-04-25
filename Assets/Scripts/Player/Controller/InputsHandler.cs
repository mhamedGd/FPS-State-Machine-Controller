using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.Events;

public class InputsHandler : MonoBehaviour
{
    Vector2 direction;
    public Vector2 GetDirection => direction;

    public void OnMovement(InputValue _value)
    {
        direction = _value.Get<Vector2>();
    }

    Vector2 delta_mouse;
    public Vector2 GetDeltaMouse => delta_mouse;
    public void OnDeltaMouse(InputValue _value)
    {
        delta_mouse = _value.Get<Vector2>();
    }

    public UnityEvent on_jump;
    public void OnJump(InputValue _value)
    {
        on_jump?.Invoke();
    }

    bool is_sprinting;
    public bool IsSprinting => is_sprinting;
    public void OnSprint(InputValue _value)
    {
        is_sprinting = _value.isPressed;
    }

    bool is_crouching;
    public bool IsCrouching => is_crouching;
    public void OnCrouch(InputValue _value)
    {
        is_crouching = _value.isPressed;
    }
}
