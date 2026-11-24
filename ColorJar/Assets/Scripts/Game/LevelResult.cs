using UnityEngine;
using UnityEngine.SceneManagement;

// LevelResult.cs (Assets/Scripts/Game): stand-in Win and Lose buttons in Level,
// until the real pour-and-sort code decides when a level is won or lost.
public class LevelResult : MonoBehaviour
{
    public void Win() // On Click () → LevelResult.Win
    {
        int reward = Services.Config.Economy.coinsPerLevel; // from config, not from code
        int coins = Services.Save.GetInt("coins");
        Services.Save.SetInt("coins", coins + reward);
        SceneManager.LoadScene("Home");
    }

    public void Lose() // On Click () → LevelResult.Lose
    {
        SceneManager.LoadScene("Home"); // no reward
    }
}