using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathCount : MonoBehaviour
{
    public int deaths = 0;
    public Text deathText;
    public float show;
    public void IncreaseDeaths()
    {
        deaths += 1;
        PlayerPrefs.SetFloat("Count", deaths);
        show = PlayerPrefs.GetFloat("Count");
        deathText.text = "Deaths: " + show;
        SceneManager.LoadScene("PlayScene");
    }
}