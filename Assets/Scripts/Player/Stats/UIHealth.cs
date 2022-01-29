using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIHealth : MonoBehaviour
{
    public Slider Slider;

    public void SetHealth(float health)
    {
        Slider.value = health;
    }
    public void SetMaxHealth(float health)
    {
        Slider.maxValue = health;
        Slider.value = health;
    }
}
