using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 1: Criando um Cubo que Roda
/// Murilo de Assis Cabral
/// 19/10/2022
/// </summary>

public class ControleCubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // rotaciona o cubo considerando o intervalo de tempo
        transform.Rotate(new Vector3(15, 30, 45)*Time.deltaTime);
    }
}
