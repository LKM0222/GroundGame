using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int tileSize = 10;
    public bool popupFlag = true;//팝업이 뜨면 레이캐스트를 막아 다른 클릭 못하도록 한다.
    
    public Sprite[] tileLevelSprite = new Sprite[5];
}
