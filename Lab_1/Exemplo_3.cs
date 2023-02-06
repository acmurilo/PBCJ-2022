using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 3: Controle de Esfera 2
/// Murilo de Assis Cabral
/// 21/09/2022
/// </summary>

public class Exemplo_3 : MonoBehaviour
{
    public float Control;
    public float OutroControl;
    public float Espiral = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Control > 20)
        {
            Control = 0;
        }
        /* Ao deixar OutroControl diferente de zero e ir alterando o Control com o "slider",
         * a esfera percorre um caminho elicoidal com raio igual ao módulo de OutroControl */
        transform.position = new Vector3(Mathf.Sin(Control)*OutroControl,
            Mathf.Cos(Control)*OutroControl, Control*OutroControl);

        if(Control < 50)
        {
            Control += Espiral;
        }
        else
        {
            Control -= Espiral;
        }
    }
}
