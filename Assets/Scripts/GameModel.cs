using System;
using System.Collections;
using System.Collections.Generic;

public class GameModel
{

    private Random rnd;

    public float thresholdWinX2;

    //Magasins
    public FloatObservable currentMoney;
    public float hitPower;
    public float moneyIncreasePerSecond;
    public float x;


    //Shop
    public int shopPrize1;
    public int shopPrize2;

    private FloatObservable waterPrice;
    private FloatObservable canPrice;
    private FloatObservable bandagePrice;
    private FloatObservable gunPrice;
    private FloatObservable shieldPrice;


    //Amount
    public int AmountWater;
    public int profit1;

    
    public int Amount2;
    public int profit2;


    //Upgrades
    public int upPrize;

    internal FloatObservable GetWater()
    {
        return waterPrice;
    }

    public GameModel()
    {
        rnd = new System.Random();

        currentMoney = new FloatObservable(0);
        hitPower = 1;
        moneyIncreasePerSecond = 1;
        x = 0f;
        thresholdWinX2 = 0.2f;
        waterPrice = new FloatObservable(25);
    }

    internal FloatObservable GetMoney()
    {
        return currentMoney;
    }

    internal void UpgradeWater()
    {
        if (currentMoney.GetValue() >= shopPrize1)
        {
            AmountWater++;
            waterPrice.Add(0.2f * waterPrice.GetValue());
        }
    }

    public void Hit()
    {
        currentMoney.Add(hitPower);
    }


    public void BuyManager()
    {
        if (currentMoney.GetValue() >= shopPrize1)
        {
            currentMoney.Add(-shopPrize1);
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
        if (currentMoney.GetValue() >= upPrize)
        {
            currentMoney.Add(-upPrize);
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


    public bool CheckX2Win()
    {
        return rnd.Next() < thresholdWinX2;
    }
}
