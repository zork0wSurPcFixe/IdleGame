using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private GameModel _gameModel;

    [SerializeField] private Button _upgradeWaterButton;
    [SerializeField] private Button _testMoneyAdd;

    //Magasins
    public FloatView moneyView;


    //Shop
    public FloatView waterView;
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
        _gameModel.GetMoney().Subscribe(moneyView);
        _gameModel.GetWater().Subscribe(waterView);
        _upgradeWaterButton.onClick.AddListener(UpgradeWater);
        _testMoneyAdd.onClick.AddListener(TestAddMoney);
       
    }

    private void TestAddMoney()
    {
        _gameModel.Hit();
    }

    private void UpgradeWater()
    {
        _gameModel.UpgradeWater();
    }

    // Update is called once per frame
    void Update()
    {
        //Click
       
        _gameModel.moneyIncreasePerSecond = _gameModel.x * Time.deltaTime;
        

        //Buy
        textShop2.text = "Tier 1: " + _gameModel.shopPrize2 + " $ ";

        TextAmount1.text = "Tier 1: " + _gameModel.AmountWater + " mps: " + _gameModel.profit1 + "/s";
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
