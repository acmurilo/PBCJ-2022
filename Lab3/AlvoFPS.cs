using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 2: Acertando as funcionalidades da c�mera para jogos em Primeira Pessoa
/// Murilo de Assis Cabral
/// 05/10/2022
/// </summary>

public class AlvoFPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // vari�veis para os valores de X e Y do mouse
    float mouseX;
    float mouseY;

    // Update is called once per frame
    void Update()
    {
        // atribui os valores de X e Y do mouse �s respectivas vari�veis
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");
        // printa esses valores
        //Debug.Log(mouseX);
        //Debug.Log(mouseY);

        /* os eixos x e y s�o trocados no script pois o componente de camera
         * tem seus eixo trocados em rela��o � vis�o do computador */
        transform.eulerAngles = new Vector3(-mouseY, mouseX, 0f);
    }
}
