using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitVelocity : MonoBehaviour
{
    public float maxFallSpeed = 10f;
    private Rigidbody2D localRGB;

    // Start is called before the first frame update
    void Start()
    {
        localRGB = GetComponent<Rigidbody2D>();
    }
    //s
    // Update is called once per frame
    void Update()
    {
        if (localRGB.velocity.magnitude > maxFallSpeed)
        {
            localRGB.velocity = Vector3.ClampMagnitude(localRGB.velocity, maxFallSpeed);
        }
    }
}

