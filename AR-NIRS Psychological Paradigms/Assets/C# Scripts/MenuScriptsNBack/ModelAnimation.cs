﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelAnimation : MonoBehaviour {

    [SerializeField] private Vector3 finalPosition;
    private Vector3 initialPosition;

    private void Awake()
    {
        initialPosition = transform.position;
    }

    private void Update () {
        transform.position = Vector3.Lerp(transform.position, finalPosition, 0.1f);
	}

    private void OnDisable()
    {
        transform.position = initialPosition;
    }
}
