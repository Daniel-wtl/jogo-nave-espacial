using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class colisaoTiro : MonoBehaviour
{
    private float telaY = Screen.height;
    public Transform posicao;
    public TMP_Text pontuacao;
    
    void Start()
    {
        pontuacao = GameObject.Find("pontuacao").GetComponent<TMP_Text>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("tagTiro")) return;

        if (other.CompareTag("naveInimiga"))
        {
            Destroy(other.gameObject);

            FindObjectOfType<tiroNave>().contadorPontuacao++;
            pontuacao.text = "Pontuação: "+FindObjectOfType<tiroNave>().contadorPontuacao;
        }

        Destroy(gameObject);
    }

    void Update(){
        if (posicao.position.y > 5.3){
            Destroy(gameObject);
        }
    }

}
