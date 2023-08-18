using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISystem : MonoBehaviour
{
    GameManager theGM;
    [Header("TilePopupUI")]
    [SerializeField] GameObject tilePopupUI;
    
    // Start is called before the first frame update
    void Start()
    {
        theGM = FindObjectOfType<GameManager>();
    }

    public void OnTileClick(){
        tilePopupUI.SetActive(true);
    }
}
