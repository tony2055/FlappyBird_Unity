using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Personagem : MonoBehaviour {


    public float forcaImpulso;
    public bool jogando;
    Rigidbody2D rb;




	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;



	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            if (!jogando)
            {
                rb.gravityScale = 1.0f;
                jogando = true;
                Placar.pontos = 0;
            }

            rb.velocity = new Vector2(0.0f, 0.0f);
            rb.AddForce(Vector2.up * forcaImpulso);
        }

        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.y * 2.0f);  
	}

    void OnCollisionEnter2D(Collision2D c)
    {
        SceneManager.LoadScene("telaInicial");
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Placar.pontos++;
    }



}
