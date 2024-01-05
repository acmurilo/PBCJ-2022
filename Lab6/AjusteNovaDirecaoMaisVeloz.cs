using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 3: Adicionando uma volta de 180º
/// Murilo de Assis Cabral
/// 11/12/2022
/// </summary>

public class AjusteNovaDirecaoMaisVeloz : MonoBehaviour
{
    /* para o script funcionar, foi alterada a propriedade de acesso das variáveis Direcao e Velocidade 
     * no outro script. como não estava definido, elas eram priavate, pois esse é o estado padrao. 
     * ao alterar para public, elas podem ser acessada por outros métodos, como esse, no caso. */

    // define as variáveis de objeto e animator
    DirecionamentoRootMotion scriptDirecionamento;
    Animator anim;

    void Start()
    {
        // atribui as variáveis aos seus respectivos componentes
        scriptDirecionamento = GetComponent<DirecionamentoRootMotion>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // muda as variáveis do animator com as variáveis deste script, as quais vêm do script DirecionamentoRootMotion
        anim.SetFloat("NovaDirecao", scriptDirecionamento.Direcao);
        anim.SetFloat("MaisVeloz", scriptDirecionamento.Velocidade); 
    }
}
