using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private GameModel _gameModel;

    //Magasins
    public Text money;


    //Shop
    public Text textShop1;
    public Text textShop2;

    //Amount
    public Text TextAmount1;
    public Text TextAmount2;

    //Upgrades
    public Text upText;


    // Start is called before the first frame update
    void Start()
    {
        _gameModel = new GameModel();
    }

    // Update is called once per frame
    void Update()
    {
        //Click
        money.text = (int)_gameModel.currentMoney + " $ ";
        _gameModel.moneyIncreasePerSecond = _gameModel.x * Time.deltaTime;
        _gameModel.currentMoney = _gameModel.currentMoney + _gameModel.moneyIncreasePerSecond;

        //Buy
        textShop1.text = "Tier 1: " + _gameModel.shopPrize1 + " $ ";
        textShop2.text = "Tier 1: " + _gameModel.shopPrize2 + " $ ";

        TextAmount1.text = "Tier 1: " + _gameModel.Amount1 + " mps: " + _gameModel.profit1 + "/s";
        TextAmount2.text = "Tier 2: " + _gameModel.Amount2 + " mps: " + _gameModel.profit2 + "/s";

        //Upgrade
        upText.text = "Cost :" + _gameModel.upPrize + " $";
    }

    public void ClicOnButton()
    {
        _gameModel.Hit();
    }

    

    public void UpgradeManager()
    {
        _gameModel.BuyManager();
    }
}
