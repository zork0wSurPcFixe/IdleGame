using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel
{


    //Magasins
    public float currentMoney;
    public float hitPower;
    public float moneyIncreasePerSecond;
    public float x;


    //Shop
    public int shopPrize1;
    public int shopPrize2;
    

    //Amount
    public int Amount1;
    public int profit1;

    
    public int Amount2;
    public int profit2;


    //Upgrades
    public int upPrize;
    


    // Start is called before the first frame update
    void Start()
    {
        currentMoney = 0;
        hitPower = 1;
        moneyIncreasePerSecond = 1;
        x = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit()
    {
        currentMoney += hitPower;
    }


    public void BuyManager()
    {
        if (currentMoney >= shopPrize1)
        {
            currentMoney -= shopPrize1;
            Amount1 += 1;
            profit1 += 1;
            x += 1;
            shopPrize1 += 25;
        }
    }

    public void DelayManager()
    {
        
    }

    public void UpgradeMultiplierVente()
    {
        if (currentMoney >= upPrize)
        {
            currentMoney -= upPrize;
            hitPower *= 2;
            upPrize *= 3;
        }
    }

    public void VitesseClients()
    {

    }

    public void FrequenceClients()
    {

    }

}
