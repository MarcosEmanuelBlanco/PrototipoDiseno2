using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    public int valor;
    // Start is called before the first frame update
    void Start()
    {
        valor = Random.Range(1, 7);
    }

    public void AbrirCofre()
    {

            GameObject jugador = GameObject.FindGameObjectWithTag("Player");
            if (jugador == null)
            {
                return;
            }
            Puntos puntos = jugador.GetComponent<Puntos>();
            if (gameObject.CompareTag("Cofre"))
            {
                puntos.SumarPuntos(valor);

            }
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
