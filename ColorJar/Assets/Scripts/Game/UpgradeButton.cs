using TMPro;
using UnityEngine;

// UpgradeButton.cs (Assets/Scripts/Game): on the Upgrade button in Home.
// Each level gives one more Extra Jar use per level. Price comes from the curve in EconomyConfig.
public class UpgradeButton : MonoBehaviour
{
    public const string Key = "extra_jar_level"; // saved upgrade level, also read in Level

    [SerializeField] CoinCounter coins; // the coin text in the HUD
    TMP_Text label;

    EconomyConfig Economy => Services.Config.Economy;
    int Level => Services.Save.GetInt(Key);
    int Cost => Economy.UpgradeCost(Level);
    bool IsMax => Level >= Economy.upgradeMaxLevel;

    void Start()
    {
        label = GetComponentInChildren<TMP_Text>(); // the button's own text
        Show();
    }

    public void Buy() // On Click () → UpgradeButton.Buy
    {
        if (IsMax || Services.Save.GetInt("coins") < Cost) return; // max, or not enough coins
        coins.Add(-Cost);                       // the sink: coins out
        Services.Save.SetInt(Key, Level + 1);   // remembered after closing the app
        Show();
    }

    void Show() => label.text = IsMax ? "Extra Jar: max" : $"Extra Jar {Level + 1}: {Cost}";
}