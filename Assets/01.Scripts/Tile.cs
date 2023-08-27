using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Tile
{
    [SerializeField] public string groundName;
    [SerializeField] public int tilePrice;
    [SerializeField] public int rank;
    [SerializeField] public int enforce; 
    [SerializeField] Building building;
}
