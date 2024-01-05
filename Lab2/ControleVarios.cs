using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 4: Criando Vários Objetos, via Script
/// Murilo de Assis Cabral
/// 12/10/2022
/// </summary>

public class ControleVarios : MonoBehaviour
{
    public int numBolas = 5;
    void Start()
    {
        // o loop cria um cubo de aresta 5 com 5x5x5=125 bolas
        for (int i = 0; i < numBolas; i++)
        {
            for (int j = 0; j < numBolas; j++)
            {
                GameObject bola = GameObject.CreatePrimitive(Primitive.Sphere); // cria as esferas
                bola.transform.position = new Vector3(i * 2.0f, j * 2.0f, 2.0f); // coloca elas no lugar certo, para nao se sobreporem
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
