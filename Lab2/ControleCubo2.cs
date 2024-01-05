using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 2: Alterando propriedades de um Componente na Cena do Game  (Parte 2)
/// Murilo de Assis Cabral
/// 12/10/2022
/// </summary>

public class ControleCubo2 : MonoBehaviour
{
    private ControleCubo Slider; // cria um objeto da classe ControleCubo
    public int mudar;

    // Start is called before the first frame update
    void Start()
    {
        Slider = GetComponent<ControleCubo>();
    }

    // Update is called once per frame
    void Update()
    {
        /* envia o valor de mudar do ControleCubo a essa variavel mudar, 
         * assim um único slider controla a cor e a posicao */
        mudar = Slider.mudar;
        if (mudar > 10)
        {
            transform.position = new Vector3(3f, 1f, 0f);
        }
        else if (mudar < -10)
        {
            transform.position = new Vector3(-3f, 1f, 0f);
        }
    }
}
