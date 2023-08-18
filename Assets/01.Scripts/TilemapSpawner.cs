using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapSpawner : MonoBehaviour
{
    [SerializeField] GameObject tile;
    GameManager theGM;
    
    // Start is called before the first frame update
    void Start()
    {
        theGM = FindObjectOfType<GameManager>();
        this.transform.position = new Vector3(-theGM.tileSize / 2,theGM.tileSize / 2,this.transform.position.z);
        TileGenerator();
    }


    void TileGenerator(){
        float tmpX = this.transform.position.x;
        float tmpY = this.transform.position.y;
        float dx;
        for(int i = 0; i<theGM.tileSize;i++){
            this.transform.position = new Vector3(tmpX,tmpY,this.transform.position.z);
            dx = tmpX;
            for(int j = 0;j<theGM.tileSize;j++){
                //타일이 생성될 때 등급에 따라 입력되어야 하는 데이터 
                tile.GetComponent<Tile>().SetPrice(tile.GetComponent<Tile>().GetLevel() * 10000);
                tile.GetComponent<Tile>().SetLevel(randomNum());
                tile.GetComponent<Tile>().SetSprite(theGM.tileLevelSprite[tile.GetComponent<Tile>().GetLevel() - 1]);
                tile.GetComponent<Tile>().SetGroundLevelToName();
                Instantiate(tile, this.transform.position, Quaternion.identity);
                dx += tile.GetComponent<BoxCollider2D>().size.x;
                print(dx);
                this.transform.position = new Vector3(dx, tmpY, this.transform.position.z);
            }
            tmpY -= tile.GetComponent<BoxCollider2D>().size.y;
        }
        
    }

    int randomNum(){
        return Random.Range(1,6);
    }
}
