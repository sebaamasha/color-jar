using TMPro;
using UnityEngine;

// CoinCounter.cs: on the coin text in the Home HUD
public class CoinCounter : MonoBehaviour
{
    [SerializeField] TMP_Text label; // drag the coin text here

    void Start() => Show();

    public void Add(int amount) // used by the upgrade (a negative amount spends coins)
    {
        Services.Save.SetInt("coins", Services.Save.GetInt("coins") + amount);
        Show();
    }

    public void AddTestCoins() // the test button: On Click () → CoinCounter.AddTestCoins
    {
        Add(Services.Config.Economy.testCoinsAmount); // the amount comes from config
    }

    void Show() => label.text = "Coins: " + Services.Save.GetInt("coins");
}