using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    int x,y;
    int level;
    int price;

    Tile(int _x, int _y, int _level, int _price){
        x = _x;
        y = _y;
        level = _level;
        price = _price;
    }
    
}
