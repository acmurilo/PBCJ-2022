using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo 4: Criando Classes Aninhadas
/// Murilo de Assis Cabral
/// 21/09/2022
/// </summary>

public class Exemplo_4 : MonoBehaviour
{
    class MuitoMuitoPrimeiraClasse
    {
        public int num;
        public void ImprimaNum()
        {
            Debug.Log(num);
        }
    }

    class OutraClasse
    {
        public class DentroNovamente
        {
            public int dentroNum = 0;
            public void ImprimaDentro()
            {
                Debug.Log(dentroNum);
            }
        }
        public int outroNum = 0;
        public void ImprimaOutroNum()
        {
            Debug.Log(outroNum);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //cria os objetos e atribui a eles o valor de num
        MuitoMuitoPrimeiraClasse PrimeiraClasse = new MuitoMuitoPrimeiraClasse();
        PrimeiraClasse.num = 1;
        MuitoMuitoPrimeiraClasse SegundaClasse = new MuitoMuitoPrimeiraClasse();
        SegundaClasse.num = 2;
        MuitoMuitoPrimeiraClasse TerceiraClasse = new MuitoMuitoPrimeiraClasse();
        TerceiraClasse.num = 3;

        //imprime o valor de num de cada objeto criado
        PrimeiraClasse.ImprimaNum();
        SegundaClasse.ImprimaNum();
        TerceiraClasse.ImprimaNum();

        //cria um objeto da classe DentroNovamente, que esta dentro da OutraClasse
        OutraClasse.DentroNovamente OCDN = new OutraClasse.DentroNovamente();

        OCDN.dentroNum = 10;
        OCDN.ImprimaDentro();

        /* como a variavel outroNum esta dentro da classe OutraClasse, mas fora da classe DentroNovamente,
         * para imprimir ela, deve-se apenas criar um objeto a partir da OutraClasse a atribuir à variável outroNum
         * o valor desejado de 20 */
        OutraClasse teste = new OutraClasse();
        teste.outroNum = 20;
        teste.ImprimaOutroNum();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}