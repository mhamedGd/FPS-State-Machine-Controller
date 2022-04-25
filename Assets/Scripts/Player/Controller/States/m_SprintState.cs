using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_SprintState : m_BaseState
{
    public m_SprintState (Agent _agent) : base(_agent) { }

    public override StateID GetState()
    {
        return StateID.Sprint;
    }

    public override void Entry()
    {
        base.Entry();
    }

    public override void Update()
    {
        if (!IsGrounded())
            agent.statesHandler.ChangeState(StateID.Fall);

        if (agent.is_sprinting && agent.inputsDirection != Vector2.zero)
            return;

        agent.statesHandler.ChangeState(StateID.Idle);
    }

    public override void FixedUpdate()
    {
        Move(agent.agentSettings.speed, agent.agentSettings.maxSprintSpeed, 1.0f);
    }

    public override void Exit()
    {
        base.Exit();
    }
}
