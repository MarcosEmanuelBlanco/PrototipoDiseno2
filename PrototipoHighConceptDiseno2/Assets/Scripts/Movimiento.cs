using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private float movimientoLateral;
    private float movimientoAvanzar;
    private Vector3 direccion;
    [SerializeField] private float velocidad;
    [SerializeField] private float rotacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoLateral = Input.GetAxis("Horizontal");
        movimientoAvanzar = Input.GetAxis("Vertical");
        direccion = new Vector3(movimientoLateral, 0, movimientoAvanzar);
        
    }

    private void FixedUpdate()
    {
        transform.Translate(direccion * velocidad);
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(transform.rotation.x, -rotacion, transform.rotation.z);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(transform.rotation.x, rotacion, transform.rotation.z);
        }
    }
}
