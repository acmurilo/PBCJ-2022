using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 6. Efeitos Gerais
/// Murilo de Assis Cabral
/// 12/12/2022
/// </summary>

public class RelogioDecrescente : MonoBehaviour
{
    // declara as variáveis
    private Text textoRelogio;
    public static float contregreTempoDuracao;
    private float contregreTempoInicio;

    private int tempoVel = 80; // variável para a comparação dos 20s (começa com o tempo total do jogo)

    void Start()
    {
        textoRelogio = GetComponent<Text>(); // instancia o component Text ao textoRelogio
        ContRegreTempoReset(80); // define o tempo da contagem regressiva (80s ou 1min20s)
    }

    void Update()
    {
        string mensagemTempo = "==> TEMPO ESGOTADO!!! ";
        int tempoRestante = (int)ContRegreSegRestantes();

        // caso a diferença entre tempoVel e tempoRestante seja maior que 20, quer dizer que passou mais 20 segundos
        if(tempoVel - tempoRestante > 20)
        {
            Zumbi.velocidade = 2*Zumbi.velocidade; // dobra a velocidade dos zumbis
            tempoVel = tempoRestante; // reseta o tempoVel para os proximos 20s
        }
        /* caso o contador nao tenha chegado a zero, ele continua fazendo a contagem
         * caso ele chegue, a mensagem mensagemTempo é mostrada */
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

    // utiliza os parâmetros definidos em ContRegreTempoReset para calcular o tempo que falta
    private float ContRegreSegRestantes()
    {
        float tempoDecorrido = Time.time - contregreTempoInicio;
        float tempoRestante = contregreTempoDuracao - tempoDecorrido;
        return tempoRestante;
    }

    // transforma o valor do tempo em string e coloca zeros � esquerda caso a string tenha menos de 2 digitos, ou seja < 10
    private string PreencheZeros(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
