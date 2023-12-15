using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : Item
{
    private Vector3 Velocity;
    public bool IsAlive = true;
    private double _decelerationTolerance = 4.0;

    void FixedUpdate()
    {
        if (IsAlive)
        {
            IsAlive = Vector3.Distance(_rb.velocity, Velocity) < _decelerationTolerance;
            Velocity = _rb.velocity;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
