using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Exemplo 1: Criando um Cubo que Roda
/// Murilo de Assis Cabral
/// 19/10/2022
/// </summary>

public class RelogioDecrescente : MonoBehaviour
{
    // declara as variáveis
    private Text textoRelogio;
    public static float contregreTempoDuracao;
    private float contregreTempoInicio;

    // Start is called before the first frame update
    void Start()
    {
        textoRelogio = GetComponent<Text>(); // instancia o component Text ao textoRelogio
        ContRegreTempoReset(30); // define o tempo da contagem regressiva (30s)
    }

    // Update is called once per frame
    void Update()
    {
        string mensagemTempo = "==> TEMPO ESGOTADO!!! ";
        int tempoRestante = (int)ContRegreSegRestantes();

        /* caso o contador nao tenha chegado a zero, ele continua fazendo a contagem
         * caso ele chegue, aa mensagem mensagemTempo é mostrada */
        if(tempoRestante > 0)
        {
            mensagemTempo = "Tempo Restante = " + PreencheZeros(tempoRestante) + "s";
        }
        textoRelogio.text = mensagemTempo;
    }

    /* define o tempo de duração da contagem regressiva, além de utilizar o contregreTempoInicio
     * como uma correção do delay entre o início do jogo e do script, assim ele semrpe será somado
     * do valor final de tempoRestante, para retornar o valor correto */
    private void ContRegreTempoReset(float tempoinicial)
    {
        contregreTempoDuracao = tempoinicial;
        contregreTempoInicio = Time.time;
    }

    private float ContRegreSegRestantes()
    {
        float tempoDecorrido = Time.time - contregreTempoInicio;
        float tempoRestante = contregreTempoDuracao - tempoDecorrido;
        return tempoRestante;
    }

    // transforma o valor do tempo em string e coloca zeros à esquerda caso a string tenha menos de 2 digitos, ou seja < 10
    private string PreencheZeros(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
