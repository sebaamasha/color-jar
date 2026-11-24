using UnityEngine;

// EconomyConfig.cs (Assets/Scripts/Services): every economy number in one asset
[CreateAssetMenu(menuName = "Game/Economy Config")]
public class EconomyConfig : ScriptableObject
{
    [Header("Sources")]
    public int coinsPerLevel = 50;
    public int dailyGift = 0;          // not in the game yet

    [Header("Upgrade, the big sink: one more Extra Jar per level")]
    public int upgradeBaseCost = 80;
    public float upgradeGrowth = 1.5f;
    public int upgradeMaxLevel = 3;

    [Header("Test button (until real levels pay coins)")]
    public int testCoinsAmount = 10;

    // Price of the next upgrade: base × growth, once per level bought. Same as the sheet.
    public int UpgradeCost(int level) =>
        Mathf.RoundToInt(upgradeBaseCost * Mathf.Pow(upgradeGrowth, level));
}