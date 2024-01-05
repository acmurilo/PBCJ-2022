using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 1: Criando um Cubo que Roda
/// Murilo de Assis Cabral
/// 19/10/2022
/// </summary>

public class ControladorCamera : MonoBehaviour
{
    // define as vari�veisa player e offset
    public GameObject player;
    public Vector3 offset;

    void Start()
    {
        // o offset vai ser a dist�ncia inicial entre o player e a c�mera
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        /* a fim de manter dist�ncia constante, a posi��o da c�mera sempre
         * ser� atualizada considerando o offset */
        transform.position = player.transform.position + offset;
    }
}
