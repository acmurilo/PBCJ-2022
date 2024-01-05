using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 2: Acertando as funcionalidades da câmera para jogos em Primeira Pessoa
/// Murilo de Assis Cabral
/// 05/10/2022
/// </summary>

public class MoveFPS : MonoBehaviour
{
    public float velocidade = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * velocidade;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * velocidade;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * velocidade;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * velocidade;
        }
    }
}
