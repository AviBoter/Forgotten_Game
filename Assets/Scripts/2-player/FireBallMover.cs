using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object in a fixed direction
 */
public class FireBallMover : MonoBehaviour
{
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 direction;

    void Start()
    {
        // destory after 1 sec
       Destroy(this.gameObject, 1);
    }

    void Update()
    {
        transform.position += direction * Time.deltaTime;
    }

    public void SetVelocity(Vector3 newVelocity)
    {
        this.direction = newVelocity;
    }
}

