using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsDatabase : MonoBehaviour
{
    public Agent playerAgent;
    public Transform mainCamera;
    public InputsHandler inputsHandler;

    public static ObjectsDatabase singleton;
    private void Awake()
    {
        if (singleton == null) singleton = this;
    }
}
