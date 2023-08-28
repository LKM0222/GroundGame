using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class GameManager : MonoBehaviour
{


    public static int tileSize = 5;
    public bool popupFlag = true;//팝업이 뜨면 레이캐스트를 막아 다른 클릭 못하도록 한다.
    [SerializeField] public Tile activeTile;
    
    public Sprite[] tileLevelSprite = new Sprite[5];
    
    public Tile[] tileList = new Tile[tileSize * tileSize];

    public void OnNextTurn(){
        for(int i = 0; i<tileSize; i++){
            for(int j = 0; j< tileSize; j++){
                //타일의 인덱스는 i* tilesize + j이다.
                int nowIdx = i * tileSize + j;
                var nowTile = tileList[nowIdx];

                if(nowTile.building.buildingEffect.Length > 0){
                    var list = nowTile.building.buildingEffect;
                    for(int n = 0; n < list.Length; n++){
                        //리스트에 있는 효과 적용 및 효과 중복적용은 시키면 안됨....
                        // list[n]
                    }
                }


            }
        }
    }
}
