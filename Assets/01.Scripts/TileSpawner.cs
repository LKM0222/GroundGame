using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField] GameObject tilePrefabs;
    GameManager theGM;
    // Start is called before the first frame update
    void Start()
    {
        theGM = FindObjectOfType<GameManager>();
        this.transform.position = new Vector3(-GameManager.tileSize / 2, GameManager.tileSize / 2, 0);
        TileInstanciate();
    }
    void TileInstanciate(){
        Vector3 spawnerPos;
        spawnerPos = this.transform.position;
        float tileXSize, tileYSize;
        tileXSize = tilePrefabs.GetComponent<BoxCollider2D>().size.x;
        tileYSize = tilePrefabs.GetComponent<BoxCollider2D>().size.y;

        for(int i = 0;i < GameManager.tileSize;i++){
            for(int j = 0; j<GameManager.tileSize;j++){
                tilePrefabs.name = "Tile" + (i * GameManager.tileSize + j);
                Tile tiles = Instantiate(tilePrefabs, this.transform.position, Quaternion.identity).GetComponent<TileObject>().tile;
                tiles.tilePrice = Random.Range(1000,10000);
                tiles.rank = Random.Range(1,6);
                tiles.tileNum = i * GameManager.tileSize + j;
                tiles.SetGroundName();
                theGM.tileList[i * GameManager.tileSize + j] = tiles;  
                this.transform.position = new Vector3(this.transform.position.x + tileXSize , this.transform.position.y, this.transform.position.z);
            }
            this.transform.position = 
            new Vector3(-GameManager.tileSize / 2, this.transform.position.y - tileYSize, this.transform.position.z);
        }
    }

    //타일 생성할때, 타일 랜덤으로 생성하고 생성한 타일은 게임메니저에 배열로 저장해야됨. 그렇게 해서 다시 UI연결작업 필요함.

}
