using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteSwitch : MonoBehaviour
{
    //[Range(valorMin, valorMax)]
    [Range(0, 10000)]
    public int pontuacao = 10000;

    // Update is called once per frame
    void Update()
    {
        switch (pontuacao)
        {
            case 2000:
                Debug.Log("E");
                break;
            case 4000:
                Debug.Log("D");
                break;
            case 6000:
                Debug.Log("C");
                break;
            case 8000:
                Debug.Log("B");
                break;
            case 10000:
                Debug.Log("A");
                break;
            default:
                Debug.Log("Valor invalido");
                break;
        }
    }
}
