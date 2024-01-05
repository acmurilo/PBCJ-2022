using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 1: Fugindo dos Zumbis.
/// Murilo de Assis Cabral
/// 05/10/2022
/// </summary>

public class GeraZumbi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject ZumbiPrefab;

    // Update is called once per frame
    void Update()
    {
        /* caso um zumbi seja destruído, um outro será criado.
         * Porém em uma posição diferente, cujo x sera dado aleatóriamente no
         * intervalo de -2 a 2. Após isso será impresso o número de zumbis */
        if (Zumbi.NumZumbi < 4)
        {
            GameObject ZumbiClone = (GameObject)Instantiate(ZumbiPrefab,
                transform.position + new Vector3((float) Random.Range(-2, 2), 0.5f, 0f), transform.rotation);
            Zumbi.NumZumbi++;
            print(Zumbi.NumZumbi);
        }
    }
}
