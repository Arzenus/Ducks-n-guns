using UnityEngine;

namespace Disparo
{
    public class Bala : MonoBehaviour
    {
        public float potencia = 40f;

        [SerializeField] private float danio = 0;
        

        public void CambioProyectil(float potenciaDelProyectil)
        {
            potencia = potenciaDelProyectil;
        }

        private void OnCollisionEnter(Collision elOtroObjeto)
        {
            if (elOtroObjeto.gameObject.CompareTag("Enemigo"))
            {
                Destroy(gameObject);
            }
        }
    }
}
