using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    GameManager theGM;
    private void Start() {
        theGM = FindObjectOfType<GameManager>();
    }
    public void OnTilePopupCloseButtonClick(){
        theGM.popupFlag = true;
    }
}
