using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TilePopupScript : MonoBehaviour
{
    GameManager theGM;
    [SerializeField] Text groundNameText;
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

    // Update is called once per frame
    void Update()
    {
        // groundNameText.text = theGM.activeTile.GetGroundName();
        // groundPriceText.text = theGM.activeTile.GetPrice().ToString();
        // groundRankText.text = theGM.activeTile.GetRank().ToString() + "등급";
    }
}
