using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/EntitySettings")]
public class EntitySettings : ScriptableObject
{
    public LayerMask groundMasks { get { return _groundMasks; } private set { _groundMasks = value; } }
    [SerializeField] LayerMask _groundMasks;

    public float speed { get { return _speed; } private set { _speed = value; } }
    [SerializeField] float _speed;

    public float maxWalkSpeed { get { return _maxWalkSpeed; } private set { _maxWalkSpeed = value; } }
    [SerializeField] float _maxWalkSpeed;

    public float maxSprintSpeed { get { return _maxSprintSpeed; } private set { _maxSprintSpeed = value; } }
    [SerializeField] float _maxSprintSpeed;

    public float maxCrouchSpeed { get { return _maxCrouchSpeed; } private set { _maxCrouchSpeed = value; } }
    [SerializeField] float _maxCrouchSpeed;

    public float cameraCrouchedPosition { get { return _cameraCrouchedPosition; } private set { _cameraCrouchedPosition = value; } }
    [SerializeField] float _cameraCrouchedPosition;

    public float cameraStandingPosition { get { return _cameraStandingPosition; } private set { _cameraStandingPosition = value; } }
    [SerializeField] float _cameraStandingPosition;

    public float cameraSensitivity { get { return _cameraSensitivity; } private set { _cameraSensitivity = value; } }
    [SerializeField] float _cameraSensitivity;

    public float maxSlopeAngle { get { return _maxSlopeAngle; } private set { _maxSlopeAngle = value; } }
    [SerializeField] float _maxSlopeAngle;

    public float maxStepHeight { get { return _maxStepHeight; } private set { _maxStepHeight = value; } }
    [SerializeField] float _maxStepHeight;

    public float smoothStep { get { return _smoothStep; } private set { _smoothStep = value; } }
    [SerializeField] float _smoothStep;

    public float jumpForce { get { return _jumpForce; } private set { _jumpForce = value; } }
    [SerializeField] float _jumpForce;


}
