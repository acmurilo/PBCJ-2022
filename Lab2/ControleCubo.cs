using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 2: Alterando propriedades de um Componente na Cena do Game
/// Murilo de Assis Cabral
/// 28/09/2022
/// </summary>

/* d. Quando o plano é desselecionado, ele some da cena 
 *    Quando o MeshCollider é desselecionado, o plano fica atravessável, pois não há mais colisão, mas sua textura ainda é visível
 *    Quando o MeshRenderer é desselecionado, o plano fica invisível, mas sua física de colisão ainda existe
 *    Ou seja, quando o plano é desselecionado, é como desselecionar o MeshCollider e o MeshRenderer */

/* k. É possível alterar a cor do Cubo nessas condições se for criada uma variávei pública que pode ser acessada no 
 *    Game Hierarchy. */
 
public class ControleCubo : MonoBehaviour
{
    public Color cor;
    public Renderer rend;
    public int mudar; // variável que pode ser alterada pelo slider

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
        // atribui a cor contida na variável cor ao Cubo
        rend = GetComponent<Renderer>();
        rend.material.color = cor;

        /* conforme a variável "mudar" é alterada pelo slider, a cor do cubo pode mudar. Isso pois
         * a condicional a seguir muda o valor da variável "cor" */
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
