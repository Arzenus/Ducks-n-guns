using Disparo;
using UnityEngine;

namespace Arma
{
    public class Disparar : MonoBehaviour
    {
        private Color original;
    
        private Material material = null;

        public Bala elPrefabDeLaBala;
        
        public GameObject lanzador;


    
        // Start is called before the first frame update
        void Start()
        {
            material = gameObject.GetComponent<Renderer>().material;

            original = material.color;
        }


        public void Disparo()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Bala p = Instantiate(elPrefabDeLaBala, lanzador.transform.position, transform.rotation);

                Rigidbody rigidbodyP = p.GetComponent<Rigidbody>();

                rigidbodyP.AddForce(lanzador.transform.forward * elPrefabDeLaBala.potencia,ForceMode.Impulse);
            }
        }

        // Update is called once per frame
        void Update()
        {

            Disparo();

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                material.color = original;

                elPrefabDeLaBala.CambioProyectil(45f);
            }
        
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                material.color = Color.red;
            
                elPrefabDeLaBala.CambioProyectil(90f);
            }
        
            if (Input.GetKeyDown(KeyCode.Alpha3))
            { 
                material.color = Color.blue;
            
                elPrefabDeLaBala.CambioProyectil(15f);
            }
        }
    }
}
