using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 5: Usando Mouse no Unity3D
/// Murilo de Assis Cabral
/// 21/09/2022
/// </summary>

public class Exemplo_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* A funcao Quaternion.Euler() rotaciona o corpo em angulos ao redor do respectivo eixo, isto é, neste caso,
         * rotaciona o corpo no eixo x em (posicao do mouse em x)º e no eixo y em (posicao do mouse em y)º */
        transform.rotation = Quaternion.Euler(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
    }
}
