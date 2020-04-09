using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAudio : MonoBehaviour
{
    private AudioSource meuAudioSource;
    public static AudioSource Instancia;

    //Singleton
    //O método AWAKE executa sempre antes do START
    void Awake()
    {
        meuAudioSource = GetComponent<AudioSource>();
        Instancia = meuAudioSource;
    }

}
