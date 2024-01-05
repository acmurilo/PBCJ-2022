using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Lab8 – Atirador FPS
/// Murilo de Assis Cabral
/// 12/12/2022
/// </summary>

public class Zumbi : MonoBehaviour
{
    // declara��o das vari�veis
    public static int NumZumbi;
    public bool morte;
    public GameObject player;
    public float velocidade = 1f;

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
        Vector3 move = transform.position + (direcao * velocidade*Time.deltaTime);
        transform.position = new Vector3(move.x, 1f, move.z); // modifica para o Zumbi n�o "levitar"

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
