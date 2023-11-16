using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Puntos : MonoBehaviour
{
    public int puntos;
    [SerializeField] private UnityEvent<int> OnScoreChanged;
    [SerializeField] private UnityEvent<string> OnTextChanged;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
        OnScoreChanged.Invoke(puntos);
        OnTextChanged.Invoke(puntos.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumarPuntos(int valor)
    {
        puntos += valor;
        OnTextChanged.Invoke(puntos.ToString());
    }
}
