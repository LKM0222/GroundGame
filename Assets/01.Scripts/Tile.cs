using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    int x,y;
    [SerializeField] int level;
    [SerializeField] int price;
    [SerializeField] int rank;
    [SerializeField] string groundName;
    [SerializeField] int enforce;
    [SerializeField] string buildingName;
    [SerializeField] string buildingType;
    [SerializeField] string buildingLevel;

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

    //setter
    public void SetLeve(int _level){
        level = _level;
    }
    public void SetSprite(Sprite _sprite){
        this.GetComponent<SpriteRenderer>().sprite = _sprite;
    }
    public void SetPrice(int _price){
        price = _price;
    }
    public void SetRank(int _rank){
        rank = _rank;
    }
    public void SetGroundName(string _name){
        groundName = _name;
    }
    public void SetEnforce(int _enforce){
        enforce = _enforce;
    }
    public void SetBuildingName(string _BName){
        buildingName = _BName;
    }
    public void SetBuildingType(string _BType){
        buildingType = _BType;
    }
    public void SetBuildingLevel(string _BLevel){
        buildingLevel = _BLevel;
    }

    //getter
    public int GetLevel(){
        return level;
    }
    public int GetPrice(int _price){
        return price;
    }
    public int GetRank(int _rank){
        return rank;
    }
    public string GetGroundName(string _name){
        return groundName;
    }
    public int GetEnforce(int _enforce){
        return enforce;
    }
    public string GetBuildingName(string _BName){
        return buildingName;
    }
    public string GetBuildingType(string _BType){
        return buildingType;
    }
    public string GetBuildingLevel(string _BLevel){
        return buildingLevel;
    }
}
