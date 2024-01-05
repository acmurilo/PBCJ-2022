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
    /* 1. o modificador public faz com que a vari�vel possa ser modificada pelo o que acontece no jogo. No caso, a colis�o
     *    do player com os cubos aumenta sua contagem, que � feita em outro script.
     * 2. o tipo static int faz com que a vari�vel possa ser acessada diretamente pela classe e n�o necessariamente por uma
     *    inst�ncia dela.
     *    A combina��o public e static faz com que a vari�vel seja a mesma para todas as inst�ncias do script. */

    private Text mensagemPlacar;
    private Text mensagemParabens;
    public static int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        mensagemPlacar = GetComponent<Text>(); // encontra o component text e atribui ele � vari�vel mensagemPlacar
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
            string mensagem = "Parab�ns! Voc� coletou todos os 15 cubos antes do tempo termianr!";
            mensagemParabens.text = mensagem;
        }
        if(contador < 15 && RelogioDecrescente.contregreTempoDuracao == 0)
        {
            string mensagem = "V�c� Perdeu!";
            mensagemParabens.text = mensagem;
        }
    }
}
