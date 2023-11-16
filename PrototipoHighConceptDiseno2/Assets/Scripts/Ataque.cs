using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    [SerializeField] private Transform posicionControladorGolpe;
    [SerializeField] private float radioGolpe;
    [SerializeField] private int dagnoGolpe;
    [SerializeField] private float intervaloEntreGolpes;
    [SerializeField] private float esperaSiguienteGolpe;
    private bool ataqueHabilitado;
    // Start is called before the first frame update
    void Start()
    {
        ataqueHabilitado = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ataqueHabilitado)
        {
            if (esperaSiguienteGolpe > 0)
            {
                esperaSiguienteGolpe -= Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.C) && esperaSiguienteGolpe <= 0)
            {
                Golpe();
                Debug.Log("impacto");
                esperaSiguienteGolpe = intervaloEntreGolpes;
            }
        }
    }

    private void Golpe()
    {

        Collider[] objetos = Physics.OverlapSphere(posicionControladorGolpe.position, radioGolpe);
        foreach (Collider col in objetos)
        {
            if (col.CompareTag("Cofre"))
            {
                col.transform.GetComponent<Cofre>().AbrirCofre();
            }

            if (col.CompareTag("Enemigo"))
            {
                col.transform.GetComponent<Enemigo>().ModificarVidaEnemigo(dagnoGolpe);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(posicionControladorGolpe.position, radioGolpe);
    }
}
