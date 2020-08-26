using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moveScript : MonoBehaviour
{
    [SerializeField] private Camera nuevaCamera;

    [SerializeField] private float sensibilidadX = 3;

    [SerializeField] private float sensibilidadY = 5;

    private float ejeX = 0, ejeY = 0;
    
    // Update is called once per frame
    void Update()
    {
        ejeX += Input.GetAxis("Mouse X") * sensibilidadX;

        ejeY += Input.GetAxis("Mouse Y") * sensibilidadY;

        var rotacionX = Quaternion.AngleAxis(ejeX, Vector3.up);

        var rotacionY = Quaternion.AngleAxis(ejeY, Vector3.left);

        transform.localRotation = rotacionX * rotacionY;
    }
}
