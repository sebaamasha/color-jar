using TMPro;
using UnityEngine;

// ExtraJarsLabel.cs (Assets/Scripts/Game): on a text in the Level HUD.
// Shows how many Extra Jar uses this level has: one per upgrade level bought in Home.
public class ExtraJarsLabel : MonoBehaviour
{
    void Start()
    {
        int extraJars = Services.Save.GetInt(UpgradeButton.Key);
        GetComponent<TMP_Text>().text = "Extra jars: " + extraJars;
    }
}