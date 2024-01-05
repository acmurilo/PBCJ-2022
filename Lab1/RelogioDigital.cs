using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using System;

/// <summary>
/// Exemplo 7: Texto atualizado continuamente, “Relógio Digital”
/// Murilo de Assis Cabral
/// 21/09/2022
/// </summary>

public class RelogioDigital : MonoBehaviour
{
    private Text textoRelogio;

    // Start is called before the first frame update
    void Start()
    {
        textoRelogio = GetComponent<Text>(); //Retorna o tipo Text se o objeto possuir e nulo se não possuir
    }

    // Update is called once per frame
    void Update()
    {
        DateTime tempo = DateTime.Now; //adquire o horario atual e atribui ele a DateTime
        string hora = CompletaZero(tempo.Hour);
        string minuto = CompletaZero(tempo.Minute);
        string segundo = CompletaZero(tempo.Second);

        textoRelogio.text = hora + "h" + minuto + "min" + segundo + "seg";
    }

    /* recebe um inteiro n e transforma ele em uma string de 2 caracteres, sendo que se so houver 1
     * o segundo sera 0 */
    string CompletaZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
