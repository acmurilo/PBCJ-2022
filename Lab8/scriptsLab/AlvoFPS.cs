using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Lab8 – Atirador FPS
/// Murilo de Assis Cabral
/// 02/12/2022
/// </summary>

public class AlvoFPS : MonoBehaviour
{
    // vari�veis para os valores de X e Y do mouse
    float mouseX;
    float mouseY;

    void Update()
    {
        // atribui os valores de X e Y do mouse �s respectivas vari�veis
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");

        /* os eixos x e y s�o trocados no script pois o componente de camera
         * tem seus eixo trocados em rela��o � vis�o do computador */
        transform.eulerAngles = new Vector3(-2*mouseY, 2*mouseX, 0f);
    }
}
