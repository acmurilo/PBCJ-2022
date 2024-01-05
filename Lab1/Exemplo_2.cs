using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 2: Controle de Esfera
/// Murilo de Assis Cabral
/// 21/09/2022
/// </summary>

public class Exemplo_2 : MonoBehaviour
{
    public float Control;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* ao mexer com o "slider" do mouse, a esfera muda de posição no display
         * se aumentamos, a esfera vai para o nordeste e se distanciando da camera,
         * enquanto se diminuirmos, ela vai para o sentido e direção opostos */
        transform.position = new Vector3(Control, Control + Control, Control * Control);
    }
}
