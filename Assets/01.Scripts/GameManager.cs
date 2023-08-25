using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class GameManager : MonoBehaviour
{
    public static int tileSize = 5;
    public bool popupFlag = true;//팝업이 뜨면 레이캐스트를 막아 다른 클릭 못하도록 한다.
    // [SerializeField] public  activeTile;
    
    public Sprite[] tileLevelSprite = new Sprite[5];
    
    // public Tile[,] tileList = new Tile[tileSize,tileSize];
}
