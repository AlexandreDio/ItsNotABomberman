using Proyecto26;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBases : MonoBehaviour
{
    public InputField keyJogador1;
    public InputField pontosJogador1;
    public InputField keyJogador2;
    public InputField pontosJogador2;
    public InputField keyJogador3;
    public InputField pontosJogador3;
    public InputField keyJogador4;
    public InputField pontosJogador4;

    public static string jogador1;
    public static string pontos1;
    public static string jogador2;
    public static string pontos2;
    public static string jogador3;
    public static string pontos3;
    public static string jogador4;
    public static string pontos4;

    private Score score = new Score();

    void Start()
    {
        //chamo a url do projeto
        
        pontos1 = "0";
        pontos2 = "0";
        pontos3 = "0";
        pontos4 = "0";


    }
     void Update()
    {
         
        AtualizarPlacar();
    }

    private void AtualizarPlacar()
    {
        jogador1 = keyJogador1.text;
        jogador2 = keyJogador2.text;
        jogador3 = keyJogador3.text;
        jogador4 = keyJogador4.text;

        pontos1 = pontosJogador1.text;
        pontos2 = pontosJogador2.text;
        pontos3 = pontosJogador3.text;
        pontos4 = pontosJogador4.text;
    }
    private void PlacarpostFirebase()
    {
        score = new Score();
        RestClient.Post(url: @"https://its-not-a-bomberman.firebaseio.com/Score/.json", score);
    }
    private void PlacarGetFirebase()
    {
        
        RestClient.Get<Score>(url: @"https://its-not-a-bomberman.firebaseio.com/Score/" + score.Jogador1 + ".json").Then(response => 
        { score = response; AtualizarPlacar();

        });
     
    }
    public void EnviarButtum()
    {
        
        PlacarpostFirebase();
    }
    //public void PegaButtum()
    //{
        
    //    jogador = pontosJogador.text;
    //    PlacarGetFirebase();
    //}
}

//pego o banco e crio ele aqui com as mesmas classe feitas no firebase

