using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mono : MonoBehaviour
{
    void Reset()
    {
        Debug.LogError("======Reset=====");
    }

    void Awake()
    {
        Debug.LogError("======Awake=====");
    }

    void OnEnable()
    {
        Debug.LogError("======OnEnable=====");
    }

    void Start()
    {
        Debug.LogError("======Start=====");
    }

    void FixedUpdate()
    {
        Debug.LogError("======FixedUpdate=====");
    }

    void Update()
    {
        Debug.LogError("======Update=====");
    }

    void LateUpdate()
    {
        Debug.LogError("======LateUpdate=====");
    }

    void OnWillRenderObject()
    {
        Debug.LogError("======OnWillRenderObject=====");
    }

    void OnGUI()
    {
        Debug.LogError("======OnGUI=====");
    }

    void OnDisable()
    {
        Debug.LogError("======OnDisable=====");
    }

    void OnDestroy()
    {
        Debug.LogError("======OnDestroy=====");
    }
}
