using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class VFXModifier : MonoBehaviour
{
    //displayed visual effect
    public VisualEffect vfx;
    //local copy of intensity
    private float intensity = 0;
    //local copy of position
    private Vector3 position = Vector3.zero;
    //local copy of rotation
    private Vector3 rotation = Vector3.zero;
    //movement speed
    public float movement_speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        intensity = 0;
        //StartCoroutine(addIntensity());
    }

    //Increment the intensity over time
    private IEnumerator addIntensity()
    {
        while (true)
        {
            intensity += Time.fixedDeltaTime;
            vfx.SetFloat("Intensity", intensity);
            yield return new WaitForFixedUpdate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        position.x = Mathf.Sin(Time.time) * 5;
        position.y = Mathf.Cos(Time.time) * 5;

        float augment = Time.deltaTime * 3;
        //rotate the attractor field
        rotation.y += augment;
        rotation.z += augment / 2;
        //movement
        /*
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= augment;
        }
        if (Input.GetKey(KeyCode.D))
        {
            position.x += augment;
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.y -= augment;
        }
        if (Input.GetKey(KeyCode.W))
        {
            position.y += augment;
        }
        */
        vfx.SetVector3("Rotation", rotation);
        vfx.SetVector3("Center", position);
    }
}
