using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 1: Primeira Fun��o
/// Murilo de Assis Cabral
/// 21/09/2022
/// </summary>

public class Exemplo_1 : MonoBehaviour
{
    //declara as vari�veis que ser�o utilizadas em MinhaFuncao
    public int i = 0;
    public int j = 17;

    // Start is called before the first frame update
    void Start()
    {
        MinhaFuncao();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /* A fun��o executa umaa repeti��o enquanto i<10, ela imprime o valor de i e incrementa 1 em seu valor,
     * depois ela faz uma verifica se j<20. Caso positivo, ela incrementa o valor das duas vari�veis em 1. */
    void MinhaFuncao()
    {
        while (i < 10)
        {
            print(i);
            i++;
            if (j < 20)
            {
                j++;
                i++;
            }
        }
    }
}
