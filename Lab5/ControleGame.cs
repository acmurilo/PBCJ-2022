using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Exemplo 2: Criando um "Player"
/// Murilo de Assis Cabral
/// 19/10/2022
/// </summary>

public class ControleGame : MonoBehaviour
{
    /* 1. o modificador public faz com que a variável possa ser modificada pelo o que acontece no jogo. No caso, a colisão
     *    do player com os cubos aumenta sua contagem, que é feita em outro script.
     * 2. o tipo static int faz com que a variável possa ser acessada diretamente pela classe e não necessariamente por uma
     *    instância dela.
     *    A combinação public e static faz com que a variável seja a mesma para todas as instâncias do script. */

    private Text mensagemPlacar;
    private Text mensagemParabens;
    public static int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        mensagemPlacar = GetComponent<Text>(); // encontra o component text e atribui ele à variável mensagemPlacar
        mensagemParabens = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // muda a mensagem para mostrar o numero de cubos coletados
        string mensagemColeta = "Coletados = " + contador;
        mensagemPlacar.text = mensagemColeta;

        if(contador == 15 && RelogioDecrescente.contregreTempoDuracao > 0)
        {
            string mensagem = "Parabéns! Você coletou todos os 15 cubos antes do tempo termianr!";
            mensagemParabens.text = mensagem;
        }
        if(contador < 15 && RelogioDecrescente.contregreTempoDuracao == 0)
        {
            string mensagem = "Võcê Perdeu!";
            mensagemParabens.text = mensagem;
        }
    }
}
