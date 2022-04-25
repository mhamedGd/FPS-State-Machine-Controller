using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_CrouchState : m_BaseState
{
    public m_CrouchState (Agent _agent) : base(_agent) { }

    public override StateID GetState()
    {
        return StateID.Crouch;
    }

    
    public override void Entry()
    {
        base.Entry();
        agent.GetComponent<CapsuleCollider>().center = new Vector3(0, -0.5f, 0);
        agent.GetComponent<CapsuleCollider>().height = 1f;
        ObjectsDatabase.singleton.mainCamera.GetComponent<CameraController>().SetYOffset(agent.agentSettings.cameraCrouchedPosition);
    }

    public override void Update()
    {
        if (!IsGrounded())
            agent.statesHandler.ChangeState(StateID.Fall);

        bool something_up = Physics.OverlapSphere(agent.transform.position - Vector3.up * 0.1f, 0.3f, agent.agentSettings.groundMasks).Length > 0;

        if (agent.is_crouching || something_up)
            return;

        agent.statesHandler.ChangeState(StateID.Idle);
    }

    public override void FixedUpdate()
    {
        Move(agent.agentSettings.speed, agent.agentSettings.maxCrouchSpeed, 1.0f);
    }

    public override void Exit()
    {
        agent.GetComponent<CapsuleCollider>().center = new Vector3(0, 0, 0);
        agent.GetComponent<CapsuleCollider>().height = 2f;
        ObjectsDatabase.singleton.mainCamera.GetComponent<CameraController>().SetYOffset(agent.agentSettings.cameraStandingPosition);
    }
}
