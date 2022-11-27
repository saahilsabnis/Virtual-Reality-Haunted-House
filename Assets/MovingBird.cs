using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBird : MonoBehaviour
{
    public float horizontalSpeed;
    public float virticalSpeed;
    public float amplitude;

    private Vector3 tempPosition;

    // Start is called before the first frame update
    void Start()
    {
        tempPosition = transform.position;
        amplitude = 1.0f;
        virticalSpeed = 0.001f;
        horizontalSpeed = 0.002f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tempPosition.x =  Mathf.Sin(Time.realtimeSinceStartup * 1000*horizontalSpeed) * 2*amplitude;
        tempPosition.y = Mathf.Cos(Time.realtimeSinceStartup * 1000*virticalSpeed) * amplitude;
        tempPosition.z = Mathf.Cos(Time.realtimeSinceStartup * 1000*virticalSpeed) * amplitude;

        transform.position = tempPosition;
    }
}
