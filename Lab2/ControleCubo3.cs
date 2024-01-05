using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 3: Relação entre Componentes distintos no Unity3D
/// Murilo de Assis Cabral
/// 12/10/2022
/// </summary>

public class ControleCubo3 : MonoBehaviour
{
    public GameObject A_Cubo;
    public GameObject B_Cubo;
    public Color cor;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // atriubui às variáveis os valores de x e y de ambos os cubos
        rend = GetComponent<Renderer>();
        float Ax = A_Cubo.transform.position.x;
        float Ay = A_Cubo.transform.position.y;
        float Bx = B_Cubo.transform.position.x;
        float By = B_Cubo.transform.position.y;


        // Se a tecla D é apertada o cubo A se move para direita, se a tecla A é apertada, ele se move para a esquerda
        if (Input.GetKey(KeyCode.D))
        {
            A_Cubo.transform.position = new Vector3(A_Cubo.transform.position.x + 0.1f, A_Cubo.transform.position.y, A_Cubo.transform.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            A_Cubo.transform.position = new Vector3(A_Cubo.transform.position.x - 0.1f, A_Cubo.transform.position.y, A_Cubo.transform.position.z);
        }

        //caso A vá mais a direita que B, ele se torna preto, se não, fica vermelho
        if (Ax > Bx) 
        {
            cor = Color.black;
        }
        else if (Ax <= Bx)
        {
            cor = Color.red;
        }

        //altera a cor do cubo A
        rend.material.color = cor;
    }
}
