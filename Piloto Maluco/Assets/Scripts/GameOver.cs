using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject imagemGamerOver;
    [SerializeField] private Text textoRecorde;

    public void ExibirInterface()
    {
        AtualizarInterface();
        imagemGamerOver.SetActive(true);
    }

    public void EsconderInterface()
    {
        imagemGamerOver.SetActive(false);
    }

    public void AtualizarInterface()
    {
        int recorde = PlayerPrefs.GetInt("recorde");
        textoRecorde.text = recorde.ToString();
    }
}