using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seleccion : MonoBehaviour
{
    private Color original;
    
    private Material material = null;

    public Bala scripDeLaBala;
    
    // Start is called before the first frame update
    void Start()
    {
        material = gameObject.GetComponent<Renderer>().material;

        original = material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            material.color = original;

            scripDeLaBala.CambioProyectil(45f);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            material.color = Color.red;
            
            scripDeLaBala.CambioProyectil(90f);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        { 
            material.color = Color.blue;
            
            scripDeLaBala.CambioProyectil(15f);
        }
    }
}
