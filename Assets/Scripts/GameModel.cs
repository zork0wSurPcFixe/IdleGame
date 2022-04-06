using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameModel : MonoBehaviour
{

    //Shop
    public Text money;
    public float currentMoney;
    public float hitPower;
    public float moneyIncreasePerSecond;
    public float x;



    //Upgrades


    
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
        money.text = (int)currentMoney + " $ ";
        moneyIncreasePerSecond = x * Time.deltaTime;
        currentMoney = currentMoney + moneyIncreasePerSecond;
    }

    public void Hit()
    {
        currentMoney += hitPower;
    }

   
    
}
