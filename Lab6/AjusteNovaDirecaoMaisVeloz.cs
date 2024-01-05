using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 3: Adicionando uma volta de 180�
/// Murilo de Assis Cabral
/// 11/12/2022
/// </summary>

public class AjusteNovaDirecaoMaisVeloz : MonoBehaviour
{
    /* para o script funcionar, foi alterada a propriedade de acesso das vari�veis Direcao e Velocidade 
     * no outro script. como n�o estava definido, elas eram priavate, pois esse � o estado padrao. 
     * ao alterar para public, elas podem ser acessada por outros m�todos, como esse, no caso. */

    // define as vari�veis de objeto e animator
    DirecionamentoRootMotion scriptDirecionamento;
    Animator anim;

    void Start()
    {
        // atribui as vari�veis aos seus respectivos componentes
        scriptDirecionamento = GetComponent<DirecionamentoRootMotion>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // muda as vari�veis do animator com as vari�veis deste script, as quais v�m do script DirecionamentoRootMotion
        anim.SetFloat("NovaDirecao", scriptDirecionamento.Direcao);
        anim.SetFloat("MaisVeloz", scriptDirecionamento.Velocidade); 
    }
}
