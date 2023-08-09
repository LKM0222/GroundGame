using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    int x,y;
    [SerializeField] int level;
    int price;

    GameManager theGM;

    private void Start()
    {
        theGM = FindObjectOfType<GameManager>();
    }
    Tile(int _x, int _y, int _level, int _price){
        x = _x;
        y = _y;
        level = _level;
        price = _price;
    }
    public void SetLeve(int _level){
        level = _level;
    }
    public void SetSprite(Sprite _sprite){
        this.GetComponent<SpriteRenderer>().sprite = _sprite;
    }

    public int GetLevel(){
        return level;
    }
    
}
