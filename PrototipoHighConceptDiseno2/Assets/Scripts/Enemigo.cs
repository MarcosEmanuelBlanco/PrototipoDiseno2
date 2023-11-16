using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private int vida;
    public int botin;
    // Start is called before the first frame update
    void Start()
    {
        botin = Random.Range(1, 7);
        vida = Random.Range(1, 4);
    }

    public void ModificarVidaEnemigo(int puntos)
    {
        vida -= puntos;
        Debug.Log("Enemigo herido");
        Muerte();
    }
    private void Muerte()
    {
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            GameObject jugador = GameObject.FindGameObjectWithTag("Player");
            if (jugador == null)
            {
                return;
            }
            Puntos puntos = jugador.GetComponent<Puntos>();
            if (gameObject.CompareTag("Enemigo"))
            {
                puntos.SumarPuntos(botin);

            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
