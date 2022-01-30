using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DeathCount : MonoBehaviour
{
    public int deaths = 0;
    public Text deathText;
    public TextMeshPro deathTextPro;
    public void IncreaseDeaths()
    {
        deaths += 1;
        deathText.text = "Deaths: " + deaths;
    }
}