using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    public Transform localInimigo;
    public GameObject naveInimiga;
    int inimigoX;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PosicaoInimigo());
    }

    IEnumerator PosicaoInimigo() // (3,10,12) --> (5,10,12)
    {
        while (true)
        {
            inimigoX = UnityEngine.Random.Range(-8,9);
            yield return new WaitForSeconds(2f);

            Vector3 local = localInimigo.position;
            local.x = inimigoX;
            localInimigo.position = local;

            Instantiate(naveInimiga, localInimigo.position, localInimigo.rotation);
        }
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
