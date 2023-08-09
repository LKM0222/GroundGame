using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISystem : MonoBehaviour
{
    GameManager theGM;
    [Header("Tile")]
    [SerializeField] GameObject tilePopupUI;
    [SerializeField] Text groundRankText;
    [SerializeField] Text groundPriceText;
    [SerializeField] Text buildingNameText;
    [SerializeField] Text buildingTypeText;
    [SerializeField] Text groundEnforceText;
    // Start is called before the first frame update
    void Start()
    {
        theGM = FindObjectOfType<GameManager>();
    }

    public void OnTileClick(){
        tilePopupUI.SetActive(true);
    }
}
