using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class UIController : MonoBehaviour
{
    public Text textFallenNumber;
    public GameController gameController;
    public int currentChipValue;
    public Text BalanceText;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        UpdateBalanceUI();
    }

    // Update is called once per frame
    void Update()
    {

       
    }

    public void ChangeChipValue()
    {
        currentChipValue = Int32.Parse(EventSystem.current.currentSelectedGameObject.name);
        gameController.selectedChipValue = currentChipValue;
        print("Current chip value :" + gameController.selectedChipValue);
    }

    public void ChangeLastNumberText()
    {
        textFallenNumber.text = gameController.lastNumbers.ToString();
    }

    public void UpdateBalanceUI()
    {
        BalanceText.text = gameController.balance.ToString();

    }
}
