using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogo : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }
}
