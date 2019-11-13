using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UITable : MonoBehaviour
{
    public Button[] numberButtons;
    public GameController gameController;
    public string[] buttonContent;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        buttonContent = new string[46];
        PopulateButtonContent();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceBet()
    {
        int numberChosen = Int32.Parse(EventSystem.current.currentSelectedGameObject.name);
        //Bet(numberChosen);

        Bet betToAdd = new Bet(gameController.selectedChipValue, gameController.betOptions[numberChosen]);
        gameController.AddBet(betToAdd);

        string oldText = numberButtons[numberChosen].GetComponentInChildren<Text>().text;
        numberButtons[numberChosen].GetComponentInChildren<Text>().text = oldText + "(" + gameController.selectedChipValue + ")";
    }


        void Bet(int betOption)
    {   
        Bet betToAdd = new Bet(gameController.selectedChipValue, gameController.betOptions[betOption]);
        gameController.AddBet(betToAdd);

        string oldText = numberButtons[betOption].GetComponentInChildren<Text>().text;
        numberButtons[betOption].GetComponentInChildren<Text>().text = oldText + "(" + gameController.selectedChipValue + ")";
    }

    void PopulateButtonContent()
    {
        for(int i = 0;i < 37; i++)
        {
            buttonContent[i] = i.ToString();
        }

        buttonContent[37] = "Black";
        buttonContent[38] = "Red";
        buttonContent[39] = "Odd";
        buttonContent[40] = "Even";
        buttonContent[41] = "1-18";
        buttonContent[42] = "19-36";
        buttonContent[43] = "1st 12";
        buttonContent[44] = "2nd 12";
        buttonContent[45] = "3rd 12";
    }

    public void updateButtons()
    {
        RemoveBetTextInButton();

        for(int i = 0; i< gameController.currentBet.Count; i++)
        {
            print(gameController.currentBet[i].bet);
           

             /* for(int j = 0; j < gameController.betOptions.Length;j++)
            {
                if ( gameController.currentBet[i].bet == gameController.betOptions[j])
                {
                     numberButtons[j].GetComponentInChildren<Text>().text = buttonContent[j] + "(" + gameController.currentBet[i].stake + ")";
                    //Bet(j);

                }

            }
            */
        }

    }

    public void RemoveBetTextInButton()
    {
        for(int i = 0; i < numberButtons.Length;i++)
        {
            numberButtons[i].GetComponentInChildren<Text>().text = buttonContent[i];
        }
    }
}
