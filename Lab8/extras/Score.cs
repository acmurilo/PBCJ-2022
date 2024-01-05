using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 6. Efeitos Gerais
/// Murilo de Assis Cabral
/// 12/12/2022
/// </summary>

public class Score : MonoBehaviour
{
    private Text mensagemScore;  // variável que gerará a mensagem do score
    public static int score = 0;  // define a contagem do score (começa em 0)

    void Start()
    {
        mensagemScore = GetComponent<Text>(); // atribui o component Text à variável mensagemScore
    }

    void Update()
    {
        string mensagemMorte = "Score =" + score; // monta a mensagem que será mostrada
        mensagemScore.text = mensagemMorte; // atribui a mensagem montada à variável do objeto para que ela seja mostrada na UI
    }
}
