using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    GameManager theGM;
    UISystem theUISystem;
    // Start is called before the first frame update
    void Start()
    {
        theGM = FindObjectOfType<GameManager>();
        theUISystem = FindObjectOfType<UISystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && theGM.popupFlag){
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos,Vector2.zero,0f);

            if(hit.collider != null){
                if(hit.transform.gameObject.layer == 6){ //6 : Tile
                    GameObject click_Obj = hit.transform.gameObject;
                    theUISystem.OnTileClick();
                    print(click_Obj.GetComponent<Tile>().GetLevel());
                }
            }          
        }   
    }
}
