using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 5: "Atirando" com Raycasting
/// Murilo de Assis Cabral
/// 12/12/2022
/// </summary>

public class Gun : MonoBehaviour
{
    public float damage = 10f; // define o dano que a arma causará
    public float range = 100f; // define a distância máxima que o tiro percorre
    public Camera fpsCam; // define a camera
    AudioSource audioData; // define o audio

    private void Start()
    {
        audioData = GetComponent<AudioSource>(); // atribui o componentte AudioSource à variável
    }

    void Update()
    {
        /* sempre que o botão esquerdo do mouse for pressionado o método Shot() será 
         * chamado para efetuar o disparo da armma */
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }

    // metodo que faz o tiro funcionar
    void Shot()
    {
        RaycastHit hit;
        audioData.Play(0); // cada vez que ele for chamado, será produzido o som do disparo
        // se o alvo está no range da arma, o tiro será contado (isto é, ele não vai pro infinito)
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            // cria o objeto target com o que foi encontrado na mira
            Target target = hit.transform.GetComponent<Target>();
            // caso um alvo seja encontrado, o dano é contado
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }

}
