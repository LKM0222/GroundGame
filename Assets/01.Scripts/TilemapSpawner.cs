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
                Instantiate(tile, this.transform.position, Quaternion.identity);
                dx += tile.GetComponent<BoxCollider2D>().size.x;
                print(dx);
                this.transform.position = new Vector3(dx, tmpY, this.transform.position.z);
            }
            tmpY -= tile.GetComponent<BoxCollider2D>().size.y;
        }
        
    }
}
