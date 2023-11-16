using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoPuntos;
    public void ActualizarTexto(string texto)
    {
        textoPuntos.text = "Puntos: " + texto;
    }
}
