using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_WalkState : m_BaseState
{
    public m_WalkState(Agent _agent) : base(_agent) { }

    public override StateID GetState()
    {
        return StateID.Walk;
    }

    public override void Entry()
    {
        base.Entry();
    }

    public override void Update()
    {
        if (agent.is_sprinting)
            agent.statesHandler.ChangeState(StateID.Sprint);

        if (!IsGrounded())
            agent.statesHandler.ChangeState(StateID.Fall);

        if (agent.is_crouching)
            agent.statesHandler.ChangeState(StateID.Crouch);

        if (agent.inputsDirection != Vector2.zero)
            return;

        agent.statesHandler.ChangeState(StateID.Idle);
    }

    public override void FixedUpdate()
    {
        Move(agent.agentSettings.speed, agent.agentSettings.maxWalkSpeed, 1.0f);
    }

    public override void Exit()
    {
        base.Exit();
    }
}
