using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    private Rigidbody rb;
    private bool puedoSaltar = true;
    private bool saltando = false;
    [SerializeField] private float fuerzaSalto;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar)
        {
            puedoSaltar = false;
        }
    }

    private void FixedUpdate()
    {
        if (!puedoSaltar && !saltando)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            saltando = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        saltando = false;
        puedoSaltar = true;
    }
}
