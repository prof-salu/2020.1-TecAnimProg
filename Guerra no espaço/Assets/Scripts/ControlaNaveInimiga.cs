using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaNaveInimiga : MonoBehaviour
{
    public AudioClip somNaveInimiga;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Laser"))
        {
            ControlaAudio.Instancia.PlayOneShot(somNaveInimiga);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
