using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour {

    public float velocidade;
    public float limiteSuperior, limiteInferior;
    Vector3 posicaoInicial;
    float limiteX;


	// Use this for initialization
	void Start () {

        posicaoInicial = transform.position;
        limiteX = posicaoInicial.x * -1;
	}
	


	// Update is called once per frame
	void Update () {

        if (GameObject.Find("jogador").GetComponent<Personagem>().jogando)
        {
            transform.Translate (Vector2.left * velocidade * Time.deltaTime);

            if(transform.position.x < limiteX)
            {
                transform.position = new Vector2 (posicaoInicial.x, Random.Range(limiteInferior, limiteSuperior));
            }

        }
	}
}
