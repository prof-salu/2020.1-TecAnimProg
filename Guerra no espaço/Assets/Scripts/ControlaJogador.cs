using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour
{
    public float velocidadeMax = 3.5f;
    public float velocidadeRot = 180;
    private float limiteDaNave = 0.5f;

    public AudioClip somExplosao;
    void Update()
    {
        //Input --> entradas de dados

        //GetKeyDown --> quando o botão é acionado
        //GetKeyUp   --> quando libera o botão
        //GetKey     --> quando o botão é pressionado

        //if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        //{
        //    Debug.Log("Esquerda");
        //}

        //if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        //{
        //    Debug.Log("Direita");
        //}

        //if (Input.GetButtonDown("Horizontal"))
        //{
        //    Debug.Log("Movendo horizontalmente");
        //}

        //if (Input.GetButtonDown("Vertical"))
        //{
        //    Debug.Log("Movendo verticalmente");
        //}

        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Debug.Log("Fire");
        //}

        //  CTRL + K + (CTRL + /) --> Comentario


        //Rotacionando a nave

        //O quaternion é utilizado para representar uma rotação
        Quaternion rotacao = transform.rotation;
        float rotacaoZ = rotacao.eulerAngles.z;

        rotacaoZ -= Input.GetAxis("Horizontal") * velocidadeRot * Time.deltaTime;

        rotacao = Quaternion.Euler(0, 0, rotacaoZ);

        transform.rotation = rotacao;


        //Movendo a nave

        //Armazena a posicao atual do jogador
        Vector3 posicao = transform.position;
        //Debug.Log(Input.GetAxis("Horizontal"));

        //posicao.x += Input.GetAxis("Horizontal") * Time.deltaTime * velocidadeMax;
        //posicao.y += Input.GetAxis("Vertical") * Time.deltaTime * velocidadeMax;
        Vector3 velocidade = new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime * velocidadeMax, 0);

        posicao += rotacao * velocidade;

        //Definindo o limite da camera do jogo

        //Limite vertical

        //cima
        if(posicao.y + limiteDaNave > Camera.main.orthographicSize)
        {
            posicao.y = Camera.main.orthographicSize - limiteDaNave;
        }

        ///baixo
        if(posicao.y - limiteDaNave < -Camera.main.orthographicSize)
        {
            posicao.y = -Camera.main.orthographicSize + limiteDaNave;
        }

        //Limite horizontal

        float proporcaoDaCena = (float) Screen.width / (float) Screen.height;

        float larguraDaCamera = Camera.main.orthographicSize * proporcaoDaCena;

        if(posicao.x + limiteDaNave > larguraDaCamera)
        {
            posicao.x = larguraDaCamera - limiteDaNave;
        }

        if(posicao.x - limiteDaNave < -larguraDaCamera)
        {
            posicao.x = -larguraDaCamera + limiteDaNave;
        }

        transform.position = posicao;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LaserInimigo") || collision.CompareTag("NaveInimiga"))
        {
            ControlaAudio.Instancia.PlayOneShot(somExplosao);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
