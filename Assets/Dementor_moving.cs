using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dementor_moving : MonoBehaviour
{
    public float horizontalSpeed;
    public float virticalSpeed;
    public float amplitude;

    private Vector3 tempPosition;

    private Vector3 startPosittion;

    // Start is called before the first frame update
    void Start()
    {
        tempPosition = transform.position;
        startPosittion = tempPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tempPosition.x = startPosittion.x + Mathf.Sin(Time.realtimeSinceStartup * 1000*horizontalSpeed) * 2*amplitude;
        tempPosition.y = startPosittion.y + Mathf.Cos(Time.realtimeSinceStartup * 1000*virticalSpeed) * amplitude;
        tempPosition.z = startPosittion.z + Mathf.Cos(Time.realtimeSinceStartup * 1000*virticalSpeed) * amplitude;

        transform.position = tempPosition;
    }
}