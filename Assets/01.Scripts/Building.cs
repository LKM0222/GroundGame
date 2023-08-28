using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Building
{
    [SerializeField] string buildingName;
    [SerializeField] int buildingCode;
    [SerializeField] int buildingType;
    [SerializeField] int buildingRank;
    [SerializeField] public int[] buildingEffect = new int[0];

    //건물 리스트 만들기 이제 건물 만드는 작업 해야됨, 그리고 게임 플레이 방법도 조금 고안해보기, 턴 이동 시 건물 어떻게 지을거고 어떤식으로 진행할건지?

    
    // public Building(string _name, int _type, int _rank){
    //     buildingName = _name;
    //     buildingType = _type;
    //     buildingRank = _rank;
    // }
    
    public void SetBuildingName(string _name){
        buildingName = _name;
    }
    public void SetBuildingCode(int _code){
        buildingCode = _code;
    }
    public void SetBuildingType(int _type){
        buildingType = _type;
    }
    public void SetBuildingRank(int _rank){
        buildingRank = _rank;
    }

    public string GetBuildingName(){
        return buildingName;
    }
    public int GetBuildingCode(){
        return buildingCode;
    }
    public int GetBuildingType(){
        return buildingType;
    }
    public int GetbuildingRank(){
        return buildingRank;
    }

}
