using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 2: Criando um "Player"
/// Murilo de Assis Cabral
/// 19/10/2022
/// </summary>

public class ControlePlayer : MonoBehaviour
{
    // define a velocidade do player e seu rigidbody
    public float vel = 1.0f;
    private Rigidbody cr;

    // Start is called before the first frame update
    void Start()
    {
        cr = GetComponent<Rigidbody>(); // encontra o component rigidbody e atribui ele à variável cr
    }

    void FixedUpdate()
    {
        /* define a movimentação do player a partir dos eixos horizontal e vertical,
         * com esses valores é criado um vetor de movimento, o qual gera uma forca, 
         * junto da velocidade, que é aplicada ao player */
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(moveHorizontal, 0.0f, moveVertical);
        print(mov);
        cr.AddForce(mov*vel);
    }

    void OnTriggerEnter(Collider outro)
    {
        // caso haja uma colisão entre o player e um cubo, o contador aumenta em uma unidade e o cubo é destruido
        if(outro.gameObject.CompareTag("Cubo"))
        {
            ControleGame.contador++;
            outro.gameObject.SetActive(false);
            //gameObject.SetActive(false);
        }
    }
}
