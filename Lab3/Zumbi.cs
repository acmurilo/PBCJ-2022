using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Preparando um Prefab: Zumbi
/// Murilo de Assis Cabral
/// 05/10/2022
/// </summary>

public class Zumbi : MonoBehaviour
{
    // declara��o das vari�veis
    public static int NumZumbi;
    public bool morte;
    public GameObject player;
    public float velocidade = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        // encontra o objeto main camera para ele servir de vis�o para o player
        player = GameObject.Find("Main Camera");
        print(NumZumbi);   
    }

    // Update is called once per frame
    void Update()
    {
        /* recebe os dados do mouse e do teclado (a partir do exemplo 2) e usa eles pra determinar
         * a orienta��o e a posi��o do player, que ser� atibuida ao transform.position por meio
         * da vari�vel move */
        Vector3 direcao = (player.transform.position - transform.position).normalized;
        float distancia = (player.transform.position - transform.position).magnitude;
        Vector3 move = transform.position + (direcao * velocidade);
        transform.position = move;

        /* caso a distancia entre o player (main camera) e um zumbi seja menor que 1,
         * a vari�vel morte fica true, com isso o zumbi � destruido e o numero decresce em 1 */
        if (distancia < 1f)
        {
            morte = true;
        }
        if (morte)
        {
            NumZumbi--;
            Destroy(gameObject);
        }
    }
}
