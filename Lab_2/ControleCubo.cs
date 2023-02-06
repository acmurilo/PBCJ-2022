using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 2: Alterando propriedades de um Componente na Cena do Game
/// Murilo de Assis Cabral
/// 28/09/2022
/// </summary>

/* d. Quando o plano � desselecionado, ele some da cena 
 *    Quando o MeshCollider � desselecionado, o plano fica atravess�vel, pois n�o h� mais colis�o, mas sua textura ainda � vis�vel
 *    Quando o MeshRenderer � desselecionado, o plano fica invis�vel, mas sua f�sica de colis�o ainda existe
 *    Ou seja, quando o plano � desselecionado, � como desselecionar o MeshCollider e o MeshRenderer */

/* k. � poss�vel alterar a cor do Cubo nessas condi��es se for criada uma vari�vei p�blica que pode ser acessada no 
 *    Game Hierarchy. */
 
public class ControleCubo : MonoBehaviour
{
    public Color cor;
    public Renderer rend;
    public int mudar; // vari�vel que pode ser alterada pelo slider

    // Start is called before the first frame update
    void Start()
    {
        cor = Color.red;
        mudar = 1;
    }

    public GameObject Cubo;

    // Update is called once per frame
    void Update()
    {
        // atribui a cor contida na vari�vel cor ao Cubo
        rend = GetComponent<Renderer>();
        rend.material.color = cor;

        /* conforme a vari�vel "mudar" � alterada pelo slider, a cor do cubo pode mudar. Isso pois
         * a condicional a seguir muda o valor da vari�vel "cor" */
        if(mudar > 10)
        {
            cor = Color.yellow;
        }
        else if (mudar < -10)
        {
            cor = Color.blue;
        }
    }
}
