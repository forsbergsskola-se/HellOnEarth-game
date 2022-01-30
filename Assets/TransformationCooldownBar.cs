using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TransformationCooldownBar : MonoBehaviour
{
    public Slider cdSlider;
    [SerializeField] private ChangeForm changeForm;
    void Start()
    {
        cdSlider.value = cdSlider.maxValue;
    }

}
