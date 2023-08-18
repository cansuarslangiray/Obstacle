using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Dropper : MonoBehaviour
{
    private MeshRenderer _renderer;
    private Rigidbody _rigidbody;
    [SerializeField] private float timeToWait = 5f;

    private void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _renderer.enabled = false;
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            //timeToWait += 5;
            _renderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}