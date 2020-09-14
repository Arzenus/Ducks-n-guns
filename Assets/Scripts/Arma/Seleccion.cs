using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seleccion : MonoBehaviour
{
    private Color original;
    // Start is called before the first frame update
    void Start()
    {
        original = gameObject.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gameObject.GetComponent<Renderer>().material.color = original;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
