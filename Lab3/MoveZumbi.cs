using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 3: Comando Foreach para Dados em Componentes/Objetos
/// Murilo de Assis Cabral
/// 19/10/2022
/// </summary>

public class MoveZumbi : MonoBehaviour
{
    Vector3 pos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    Vector3 novapos = new Vector3();

    // Update is called once per frame
    void Update()
    {
        /* a nova posição do zumbi será dada aleatoriamente no circulo 
         * de raio igual a 0.2 entorno dele */
        novapos = Random.insideUnitCircle * 0.2f;
        pos.x += novapos.x;
        pos.z += novapos.z;
        transform.position = pos;
    }
}
