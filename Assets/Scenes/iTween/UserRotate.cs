using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserRotate : MonoBehaviour
{

    float rotationSpeed = 4f;
    Quaternion Oldposition;
    Vector3 pos = new Vector3(0, 0, 0);
    GameObject atom;

    private void Start()
    {
        atom = GameObject.Find("Oxygen");
        Oldposition = transform.rotation;
    }
    public void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Pressed left click.");
            float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
               float YAxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
            transform.Rotate(XaxisRotation, YAxisRotation, 0);
               // transform.Rotate(Vector3.down, XaxisRotation);
                // transform.Rotate(Vector3.right, YAxisRotation);
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("Released");
            iTween.RotateTo(atom,pos,1.6f);
            //transform.rotation = Oldposition;
        } 
    }

}
