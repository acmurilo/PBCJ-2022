using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///Exemplo 8: Mensagens de Texto 3D
///Nome: Murilo de Assis Cabral
///Data: 03/10/2022
///</summary>

public class ScrollZ : MonoBehaviour
{
    public float scrollSpeed = 20;

    /* o void update() vai mudar a posicao do texto conforme o tempo passa.
     * ele faz isso mudando o Y da posicao atraves da multiplicacao de um
     * vetor (0, 1, 0) com a velocidade desejada e o tempo decorrido */
    void update()
    {
        Vector3 pos = transform.position;
        Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);
        pos += localVectorUp * scrollSpeed * Time.deltaTime;
        transform.position = pos;
    }
}