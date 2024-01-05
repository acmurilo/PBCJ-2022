using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 4: Pulando Obst�culos
/// Murilo de Assis Cabral
/// 11/12/2022
/// </summary>

public class Jump : MonoBehaviour
{
    // defini��o de vari�veis p�blicas para serem acessadas externamente
    public float jumpForcaUp = 5f;
    public float jumpForcaForward = 10f;
    public float gravidadeAdicional = 5f;
    public float maxGroundCheckDistance = 0.3f;
    public float groundCheckPauseTime = 0.5f;

    public Transform groundCheck;
    Animator anim;
    Rigidbody rb;
    public bool noChao = true;
    float lastJumpTime = 0f;


    void Start()
    {
        // atribui��o dos componentes �s vari�veis
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        /* caso a tecla espa�o seja apertada e o caractere esteja no ch�o, uma for�a � aplicada nele para 
         * que o pulo aconte�a. alem disso, a variavei noChao fica false e o tempo de quando aconteceu
         * o pulo "reseta" (linha 41) */
        if(Input.GetKey(KeyCode.Space) && noChao)
        {
            lastJumpTime = Time.time;
            anim.applyRootMotion = false;
            noChao = false;
            rb.AddForce(Vector3.up * jumpForcaUp + transform.forward * jumpForcaForward, ForceMode.Impulse);
            anim.SetTrigger("Pulo");
        }
        GroundCheck();
    }

    // verifica se o caractere ja esta no chao ou n�o
    void GroundCheck()
    {
        /* caso o tempo seja maior que o do ultimo pulo + uma constante (para que haja um delay entre um pulo e outro)
         * e seja checado que o caractere realmente est� no ch�o pela sua dist�ncia, noChao fica true e o anim.applyRootMotion tamb�m */
        if(Time.time > lastJumpTime + groundCheckPauseTime && Physics.Raycast(groundCheck.position, Vector3.down, maxGroundCheckDistance))
        {
            noChao = true;
            anim.applyRootMotion = true;
        }
        else
        {
            noChao = false;
        }
        anim.SetBool("NoChao", noChao);
    }

    void FixedUpdate()
    {
        // aplica a for�a para que o caractere retorne ao ch�o
        if(gravidadeAdicional > 0f && !noChao)
        {
            rb.AddForce(Vector3.down * gravidadeAdicional, ForceMode.Force);
        }
    }
}
