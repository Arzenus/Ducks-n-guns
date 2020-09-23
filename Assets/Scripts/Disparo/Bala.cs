using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bala : MonoBehaviour
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

            rigidbodyP.AddForce(transform.forward * potencia,ForceMode.Impulse);
        }
    }

    public void CambioProyectil(float potenciaDelProyectil)
    {
        potencia = potenciaDelProyectil;
    }

    private void OnTriggerEnter(Collider elOtroObjeto)
    {
        if (elOtroObjeto.gameObject.CompareTag("Enemigo"))
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// /////////////////////
    /// </summary>
    void Update()
    {
        Accion();
    }
}
