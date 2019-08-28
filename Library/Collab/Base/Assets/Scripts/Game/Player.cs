﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(NetworkTransform))]
[RequireComponent(typeof(NetworkIdentity))]


public class Player : NetworkBehaviour
{
    Animator animator;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Player_Flip flip_Cod;

    [Header ("Velocidade do player")]
    [SerializeField]
    public float MoveSpeed = 0.1f;
    string elementos;

    bool facingRight;
    public GameObject grafic;

    // bool Parado = false;

    void Awake()
    {
        flip_Cod = GetComponent<Player_Flip>(); 
    }



    void Start()
    {
        if (!isLocalPlayer)
        {
            Destroy(this);
            return;
        }
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void FixedUpdate()
    {
        AguaMovimento();    
    }

    [ClientRpc]
    public void AguaMovimento()
    {    
        if (Input.GetKey("d"))
        {
            //switch (elementos.ToLower())
            //{
            //    case "agua":
            animator.Play("AguaLadoE");

            //        break;
            //    case "terra":
            //        animator.Play("TerraLado");

            //        break;
            //    case "fogo":
            //        animator.Play("FogoLado");

            //        break;
            //    case "ar":
            //        animator.Play("ArLado");

            //        break;
            //}
            transform.Translate(new Vector2(MoveSpeed, rigid.velocity.y));          
        }
        else if (Input.GetKey("a"))
        {
            //    switch (elementos.ToLower())
            //    {
            //        case "agua":
            animator.Play("AguaLado");

            //        break;
            //    case "terra":
            //        animator.Play("TerraLado");

            //        break;
            //    case "fogo":
            //        animator.Play("FogoLado");

            //        break;
            //    case "ar":
            //        animator.Play("ArLado");

            //        break;
            //}
            transform.Translate(new Vector2(-MoveSpeed, rigid.velocity.y));
        }
        else if (Input.GetKey("w"))
        {
            //switch (elementos.ToLower())
            //{
            //    case "agua":
            animator.Play("AguaCima");

            //        break;
            //    case "terra":
            //        animator.Play("TerraCima");

            //        break;
            //    case "fogo":
            //        animator.Play("FogoCima");

            //        break;
            //    case "ar":
            //        animator.Play("ArCima");

            //        break;
            //}
            transform.Translate(new Vector2(rigid.velocity.x, MoveSpeed));
   
        }
        else if (Input.GetKey("s"))
        {
            //switch (elementos.ToLower())
            //{
            //    case "agua":
            animator.Play("AguaBaixo");

            //        break;
            //    case "terra":
            //        animator.Play("TerraBaixo");

            //        break;
            //    case "fogo":
            //        animator.Play("FogoBaixo");

            //        break;
            //    case "ar":
            //        animator.Play("ArBaixo");

            //        break;
            //}
            transform.Translate(new Vector2(rigid.velocity.x, -MoveSpeed));
        }
        else
        {
            //switch (elementos.ToLower())
            //{
            //    case "agua":
            animator.Play("AguaParado");

            //        break;
            //    case "terra":
            //        animator.Play("TerraParado");

            //        break;
            //    case "fogo":
            //        animator.Play("FogoParado");

            //        break;
            //    case "ar":
            //        animator.Play("ArParado");

            //        break;
            //}
            rigid.velocity = new Vector2(0, 0);          
        }
    } 
}
