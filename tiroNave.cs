using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroNave : MonoBehaviour
{
    public GameObject tiro;
    public Transform pontoDisparo;

    public Transform qtdMunicao;
    private int municao= 10;

    bool inputBloqueado= false;

    public int contadorPontuacao = 0;

    void Start()
    {

    }

    void Update()
    {
        if (inputBloqueado!= true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (municao >= 1)
                {
                    Instantiate(tiro, pontoDisparo.position, pontoDisparo.rotation);
                    municao=municao-1;

                    Vector3 escalaAtual= qtdMunicao.localScale; //pega o tamanho atual
                    escalaAtual.x -= 0.4f;
                    qtdMunicao.localScale= escalaAtual;//atualiza o tamanho

                    Vector3 posicaoAtual= qtdMunicao.position;
                    posicaoAtual.x -= 0.1994f;
                    qtdMunicao.position = posicaoAtual;

                }
                if (municao == 0)
                {   
                    inputBloqueado = true;
                    StartCoroutine(Recarregar());
                }
            }
        }
    }

    // funcao q permite esperar
    IEnumerator Recarregar()
    {
        yield return new WaitForSeconds(1.5f); // retorno e o tempo de espera
        municao = 10;
        Vector3 escalaRecarregar= qtdMunicao.localScale;
        escalaRecarregar.x = 4;
        qtdMunicao.localScale = escalaRecarregar;

        Vector3 posicaoRecarregar= qtdMunicao.position;
        posicaoRecarregar.x = -7.82f;
        qtdMunicao.position = posicaoRecarregar;

        inputBloqueado = false;
        
    }

}
