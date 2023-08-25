using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Building
{
    [SerializeField] string buildingName;
    [SerializeField] int buildingType;
    [SerializeField] int buildingRank;
    [SerializeField]int[] buildingEffect = new int[0];
    
    public Building(string _name, int _type, int _rank){
        buildingName = _name;
        buildingType = _type;
        buildingRank = _rank;
    }
    
    public void SetBuildingName(string _name){
        buildingName = _name;
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
    public int GetBuildingType(){
        return buildingType;
    }
    public int GetbuildingRank(){
        return buildingRank;
    }

}
