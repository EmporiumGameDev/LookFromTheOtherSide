using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : Item
{
    public Vector3 Velocity;
    public Rigidbody RidgedBody;
    public bool IsAlive = true;
    private double _decelerationTolerance = 6.0;

    void Start()
    {
        RidgedBody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
    }
}
