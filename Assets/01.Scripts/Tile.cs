using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Tile
{
    [SerializeField] public string groundName;
    [SerializeField] public int tileNum;
    [SerializeField] public int tilePrice;
    [SerializeField] public int rank;
    [SerializeField] public int enforce; 
    [SerializeField] public Building building;

    public void SetGroundName(){
        switch(rank){
            case 1:
                groundName = "이상한 땅";
                break;
            case 2:
                groundName = "조금 이상한 땅";
                break;
            case 3:
                groundName = "보통 땅";
                break;
            case 4:
                groundName = "좋은 땅";
                break;
            case 5:
                groundName = "환상의 땅";
                break;
        }
    }
    
}
