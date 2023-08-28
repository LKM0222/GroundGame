using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileObject : MonoBehaviour
{
    [SerializeField] public Tile tile;
    GameManager theGM;
    private void Start() {
        theGM = FindObjectOfType<GameManager>();
        this.GetComponent<SpriteRenderer>().sprite = theGM.tileLevelSprite[tile.rank - 1];
    }
    
}
