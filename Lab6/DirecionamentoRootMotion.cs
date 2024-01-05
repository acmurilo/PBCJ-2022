using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 1: Direcionamento de um Caractere
/// Murilo de Assis Cabral
/// 11/12/2022
/// </summary>

public class DirecionamentoRootMotion : MonoBehaviour
{
    // define as variaveis
    public Transform cameraTransform;
    Animator anim;
    public float horizontal = 0.0f; // publico pois vai ser acessada externamente
    public float vertical = 0.0f;
    public float Velocidade;
    public float Direcao;
    Vector3 cameraHorizontalFrente;
    Vector3 moveDirecaoDesejada;


    void Start()
    {
        anim = GetComponent<Animator>(); // atribui o componente anim ao animator
    }

    void Update()
    {
        // recebe os valores das teclas direcionais
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // cria um vetor com os componentes x e z da camera e usa ele para definir a direcao da camera (sempre atrás do caractere)
        cameraHorizontalFrente = new Vector3(cameraTransform.forward.x, 0.0f, cameraTransform.forward.z).normalized;

        // vetor que aponta para a direção que o caractere deve ir
        moveDirecaoDesejada = vertical * cameraHorizontalFrente + horizontal * cameraTransform.right;

        // a direcao será o produto interno multiplicado pelo angulo entre eles
        Direcao = Vector3.Angle(transform.forward, moveDirecaoDesejada) * Mathf.Sign(Vector3.Dot(moveDirecaoDesejada, transform.right));

        // atribui o modulo do vetor à velocidade
        Velocidade = moveDirecaoDesejada.magnitude;

        // muda as variáveis do animator com as variáveis deste script. o Time.deltaTime é a taxa de atualização
        anim.SetFloat("Direcao", Direcao, 0.2f, Time.deltaTime);
        anim.SetFloat("Velocidade", Velocidade, 0.2f, Time.deltaTime);

    }
}
