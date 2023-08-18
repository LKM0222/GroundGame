using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    int x,y;
    [SerializeField] int level; //처음 시작할 때 땅의 레벨 변동 x
    [SerializeField] long price;
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

    private void Update()
    {
        SetGroundRank();
    }

    public Tile(int _x, int _y, int _level, int _price){
        x = _x;
        y = _y;
        level = _level;
        price = _price;
    }

    //setter
    public void SetLevel(int _level){
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
    public long GetPrice(){
        return price;
    }
    public int GetRank(){
        return rank;
    }
    public string GetGroundName(){
        return groundName;
    }
    public int GetEnforce(){
        return enforce;
    }
    public string GetBuildingName(){
        return buildingName;
    }
    public string GetBuildingType(){
        return buildingType;
    }
    public string GetBuildingLevel(){
        return buildingLevel;
    }

    //etc
    public void SetGroundLevelToName(){
        switch(level){
            case 1:
                groundName = "척박한 땅";
                break;
            case 2:
                groundName = "그저 그런 땅";
                break;
            case 3:
                groundName = "좋은 땅";
                break;
            case 4:
                groundName = "기름진 땅";
                break;
            case 5:
                groundName = "환상의 땅";
                break;
        }
    }

    public void SetGroundRank(){
        if(price > 10000000000){ //100억
            rank = 1;
        }
        else if(price > 1000000000){ // 10억
            rank = 2;
        }
        else if(price > 10000000){ // 천만
            rank = 3;
        }
        else if(price > 100000){ // 십만
            rank = 4;
        }
        else{
            rank = 5;
        }
    }
}
