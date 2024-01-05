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
    // define as variáveisa player e offset
    public GameObject player;
    public Vector3 offset;

    void Start()
    {
        // o offset vai ser a distância inicial entre o player e a câmera
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        /* a fim de manter distância constante, a posição da câmera sempre
         * será atualizada considerando o offset */
        transform.position = player.transform.position + offset;
    }
}
