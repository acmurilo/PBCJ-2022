using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Lab8 – Atirador FPS
/// Murilo de Assis Cabral
/// 02/12/2022
/// </summary>

public class MoveFPS : MonoBehaviour
{
    public float velocidade = 0.1f; // define a velocidade do player

    void Update()
    {
        // tecla W pressionada implica a camera (jogador) ir para frente
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * velocidade;
        }
        // tecla S pressionada implica a camera (jogador) ir para trás
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * velocidade;
        }
        // tecla A pressionada implica a camera (jogador) ir para esquerda
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * velocidade;
        }
        // tecla D pressionada implica a camera (jogador) ir para direita
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * velocidade;
        }
    }
}
