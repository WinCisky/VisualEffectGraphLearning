using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class VFXMove : MonoBehaviour
{
    //displayed visual effect
    public VisualEffect vfx;
    //position on the center of the visual effect point
    public Vector3 pos = Vector3.zero;

    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(cam.ScreenToWorldPoint(new Vector3(100,5,10)));
    }

    // Update is called once per frame
    void Update()
    {
        pos = Input.mousePosition;
        pos.z = 10;
        pos = cam.ScreenToWorldPoint(pos);
        //vfx.SetVector3("Center", new Vector3(pos.x, pos.y, 0));
        //cam.
        //vfx.SetVector3("Rotation", cam.transform.position);
    }
}
