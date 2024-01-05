using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 1: Fugindo dos Zumbis
/// Murilo de Assis Cabral
/// 05/10/2022
/// </summary>

public class FugirZumbi : MonoBehaviour
{
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        // recebe o valor inicial de transform.position
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // atribui o estado teclas W, A, S e D às  respectivas variáveis
        bool TeclaA = Input.GetKey(KeyCode.A);
        bool TeclaS = Input.GetKey(KeyCode.S);
        bool TeclaD = Input.GetKey(KeyCode.D);
        bool TeclaW = Input.GetKey(KeyCode.W);


        /* caso alguma das teclas seja apertada, a sua variável ficará
         * true e a posição do zumbi será afetada naquela direção */
        if(TeclaA){
            pos.x -= 0.1f;
        }
        if(TeclaD){
            pos.x += 0.1f;
        }
        if(TeclaW){
            pos.z += 0.1f;
        }
        if(TeclaS){
            pos.z -= 0.1f;
        }
        gameObject.transform.position = pos;
    }
}
