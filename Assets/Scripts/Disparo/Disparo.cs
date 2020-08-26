using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class Disparo : MonoBehaviour
{
    [SerializeField] private float potencia = 0;

    [SerializeField] private float danio = 0;

    public void accion()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Translate(potencia, 0, 0);
        }
    }
}
