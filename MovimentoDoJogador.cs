using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    private Rigidbody2D oRigidBody2D;

    private float speed = 8f;
    private Vector2 inputDeMovimento = new Vector2(0,0);

    private void Start()
    {
        oRigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ReceberInput();
    }

    private void FixedUpdate()
    {
        MovimentarJogador();
    }

    private void ReceberInput()
    {
        inputDeMovimento= new Vector2(Input.GetAxisRaw("Horizontal"), 0);
    }

    private void MovimentarJogador()
    {
        oRigidBody2D.velocity = inputDeMovimento.normalized * speed;
    }
}
