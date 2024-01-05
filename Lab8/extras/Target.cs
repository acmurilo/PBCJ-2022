using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 6. Efeitos Gerais
/// Murilo de Assis Cabral
/// 12/12/2022
/// </summary>

public class Target : MonoBehaviour
{
    // define a vida do zumbi e inicia o score
    public float health = 10f;

    /* método para contar o dano recebido pelos zumbis
     * com os disparos */
    public void TakeDamage(float amount)
    {
        // caso o método for chamado, o dano causado pela arma será retirado da vida do alvo
        health -= amount;
        // caso a vida fique negativa, o alvo será destrído (morrerá)
        if (health <= 0f)
        {
            Die();
            Score.score++; // a cada vez que um zumbi morre, o score é aumentado em uma unidade
        }
    }

    // método que faz com que o zumbi morra (GameObject destuído)
    void Die()
    {
        Destroy(gameObject);
    }
}
