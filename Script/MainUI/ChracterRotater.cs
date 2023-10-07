using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterRotater : MonoBehaviour
{
    bool rotating;
    public float rotateSpeed = 10;
    Vector3 mousePos, offset, rotation;

    void OnMouseDown()
    {
        rotating = true;

        mousePos = Input.mousePosition; 
    }

    void OnMouseUp()
    {
        rotating= false;
    }
    private void Update()
    {
        if(rotating)
        {
            offset = (Input.mousePosition - mousePos);

            rotation.y = -(offset.x + offset.y) * Time.deltaTime * rotateSpeed;

            transform.Rotate(rotation);

            mousePos = Input.mousePosition;
        }
    }
}
