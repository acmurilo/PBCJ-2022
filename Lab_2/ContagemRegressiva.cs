using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ContagemRegressiva : MonoBehaviour
{
    private Text textoContador;
    private float duracaoTimerRegressivo;
    private float tempoInicialRegressivo;

    // Start is called before the first frame update
    void Start()
    {
        textoContador = GetComponent<Text>();
        ResetTimerRegressivo(30);
    }

    // Update is called once per frame
    void Update()
    {
        string mensagemTimer = "Tempo Esgotado";
        int tempoRestante = (int)SegundosRestantesTimerRegressivo();

        if (tempoRestante > 0)
        {
            mensagemTimer = "Segundos Restantes = " + LeadingZero(tempoRestante);
        }

        textoContador.text = mensagemTimer;
    }

    private void ResetTimerRegressivo(float atrasoEmSegundos)
    {
        duracaoTimerRegressivo = atrasoEmSegundos;
        tempoInicialRegressivo = Time.time;
    }

    private float SegundosRestantesTimerRegressivo()
    {
        float segundosCorridos = Time.time - tempoInicialRegressivo;
        float tempoRestante = duracaoTimerRegressivo - segundosCorridos;
        return tempoRestante;
    }

    private string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
