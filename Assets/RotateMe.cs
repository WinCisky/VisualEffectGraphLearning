using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public float speed = 3f;
    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(Time.deltaTime * speed, Vector3.forward);
    }
}
