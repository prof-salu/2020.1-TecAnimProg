using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField] private Text pontuacao;
    private int pontos = 0;

    public void MarcarPonto()
    {
        pontos++;
        pontuacao.text = pontos.ToString();
    }

    public void ResetarPlacar()
    {
        pontos = 0;
        pontuacao.text = "0";
    }

    public void SalvarPontuacao()
    {
        int recordeSalvo = PlayerPrefs.GetInt("recorde");
        
        if(pontos > recordeSalvo)
        {
            PlayerPrefs.SetInt("recorde", pontos);
        }
        
        Debug.Log(PlayerPrefs.GetInt("recorde"));
    }
}
