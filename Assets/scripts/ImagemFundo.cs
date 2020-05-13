using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagemFundo : MonoBehaviour {


    public float limiteX;
    public float retornarX;
    public float velocidade;

	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector2.left * velocidade * Time.deltaTime);

        if (transform.position.x<limiteX)
        {
            transform.position = new Vector3(retornarX, 0.0f, 0.0f);
        }










		
	}
}
