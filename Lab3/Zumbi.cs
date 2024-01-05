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
    // declaração das variáveis
    public static int NumZumbi;
    public bool morte;
    public GameObject player;
    public float velocidade = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        // encontra o objeto main camera para ele servir de visão para o player
        player = GameObject.Find("Main Camera");
        print(NumZumbi);   
    }

    // Update is called once per frame
    void Update()
    {
        /* recebe os dados do mouse e do teclado (a partir do exemplo 2) e usa eles pra determinar
         * a orientação e a posição do player, que será atibuida ao transform.position por meio
         * da variável move */
        Vector3 direcao = (player.transform.position - transform.position).normalized;
        float distancia = (player.transform.position - transform.position).magnitude;
        Vector3 move = transform.position + (direcao * velocidade);
        transform.position = move;

        /* caso a distancia entre o player (main camera) e um zumbi seja menor que 1,
         * a variável morte fica true, com isso o zumbi é destruido e o numero decresce em 1 */
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
