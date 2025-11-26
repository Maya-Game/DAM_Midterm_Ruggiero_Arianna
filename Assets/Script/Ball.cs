using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startingSpeed;
    public Rigidbody2D body2D;

    internal void ResetPosition()
    {
        throw new NotImplementedException();
    }

    private void Start()
    {
        body2D.linearVelocity = startingSpeed;
    }
}

