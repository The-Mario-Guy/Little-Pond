using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetscopCamera : MonoBehaviour
{
    public Transform target; // The target to follow (e.g., the player)
    public float smoothSpeed = 0.125f; // The speed at which the camera follows the target
    public Vector3 offset; // The offset from the target's position

    // LateUpdate is called after all Update functions have been called
    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target); // Make the camera look at the target
        }

    }
}