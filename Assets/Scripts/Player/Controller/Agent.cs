using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public StatesHandler statesHandler { get; private set; }
    public StateID initialState;

    public EntitySettings agentSettings;

    public Vector2 inputsDirection { get; private set; }    
    public void SetInputsDirection(Vector2 _value) { inputsDirection = _value; }

    public bool is_sprinting { get; private set; }
    public void SetSprinting(bool _value) { is_sprinting = _value; }

    public bool is_crouching { get; private set; }
    public void SetCrouching(bool _value) { is_crouching = _value; }

    Rigidbody rb;
    public Rigidbody GetRigidbody() { return rb; }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        statesHandler = new StatesHandler(this);        
    }

    private void Update()
    {
        statesHandler.UpdateState();
    }

    private void FixedUpdate()
    {
        statesHandler.FixedUpdateState();
    }
}
