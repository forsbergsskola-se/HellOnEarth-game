using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TransformationCooldownBar : MonoBehaviour
{
    [SerializeField] private GameObject crowFace;
    [SerializeField] private GameObject odenFace;
        public Slider cdSlider;
    [SerializeField] private ChangeForm changeForm;
    void Start()
    {
        cdSlider.value = cdSlider.maxValue;
    }

    public void ChangeFace()
    {
        if (odenFace.activeInHierarchy)
        {
            crowFace.SetActive(true);
            odenFace.SetActive(false);
        }
        else
        {
            crowFace.SetActive(false);
            odenFace.SetActive(true);
        }
    }
    
}
