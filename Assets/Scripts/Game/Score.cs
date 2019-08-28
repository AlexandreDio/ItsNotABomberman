using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [Serializable]
public class Score 
{
    public string Jogador1;
    public string Jogador2;
    public string Jogador3;
    public string Jogador4;

    public string Pontos1;
    public string Pontos2;
    public string Pontos3;
    public string Pontos4;

    public Score()
    {

        Jogador1 = FireBases.jogador1;
        Jogador2 = FireBases.jogador2;
        Jogador3 = FireBases.jogador3;
        Jogador4 = FireBases.jogador4;

        Pontos1 = FireBases.pontos1;
        Pontos2 = FireBases.pontos2;
        Pontos3 = FireBases.pontos3;
        Pontos4 = FireBases.pontos4;
    }


    
}
