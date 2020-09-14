using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class Disparo : MonoBehaviour
{
    public float potencia = 40f;

    [SerializeField] private float danio = 0;

    public GameObject proyectil;

    public void Accion()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject p = Instantiate(proyectil, transform.position, transform.rotation);

            Rigidbody rigidbodyP = p.GetComponent<Rigidbody>();

            rigidbodyP.velocity = transform.forward * potencia;
        }
    }

    public void CambioProyectil()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            potencia = 40f;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            potencia = 90f;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            potencia = 15f;
        }
    }

}
