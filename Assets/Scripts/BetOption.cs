using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetOption : MonoBehaviour
{
    public RouletteNumber[] numbersInBet;
    public int multiplier;

    public BetOption(RouletteNumber[] rouletteNumbers, int mMultiplier)
    {
        numbersInBet = rouletteNumbers;
        multiplier = mMultiplier;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
