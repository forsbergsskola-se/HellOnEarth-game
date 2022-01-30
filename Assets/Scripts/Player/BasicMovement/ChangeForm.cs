using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeForm : MonoBehaviour
{
    public GameObject oden;
    public GameObject crow;
    [SerializeField] private ParticleSystem ps;
    public bool offCoolDown = true;
    [SerializeField] private TransformationCooldownBar cdBar;
    public bool transformInput;
    public bool transformed;
    [SerializeField] private Animator crowAnimator;
    [SerializeField] private Animator odenAnimator;
    
    
    public float transformationCoolDown = 3;
    // Update is called once per frame
    void Update()
    {
        transformInput = Input.GetButton("Fire2");
        if (transformInput && offCoolDown)
        {
            StartCoroutine(TransformPlayer());
            offCoolDown = false;
            cdBar.cdSlider.value = 40f;
        }

        if (crow.activeInHierarchy)
        {
            oden.transform.position = crow.transform.position;
        }
        else if (oden.activeInHierarchy)
        {
            crow.transform.position = oden.transform.position;
        }
        
    }

    IEnumerator TransformPlayer()
    {
       
            if (!transformed)
            {
                ps.Play();
                oden.SetActive(false);
                crow.SetActive(true);
                crowAnimator.Play("Oden bird sit");
                cdBar.ChangeFace();
                yield return new WaitForSeconds(transformationCoolDown/4);
                cdBar.cdSlider.value += 15f;
                crowAnimator.Play("Oden bird sit");
                yield return new WaitForSeconds(transformationCoolDown/4);    
                cdBar.cdSlider.value += 15f;
                yield return new WaitForSeconds(transformationCoolDown/4);  
                cdBar.cdSlider.value += 15f;
                yield return new WaitForSeconds(transformationCoolDown/4);  
                cdBar.cdSlider.value += 15f;
                transformed = true;
                offCoolDown = true;
            }
            else if (transformed)
            {
                ps.Play();
                oden.SetActive(true);
                crow.SetActive(false);
                odenAnimator.Play("Oden Idle");
                cdBar.ChangeFace();
                yield return new WaitForSeconds(transformationCoolDown/4);
                cdBar.cdSlider.value += 15f;
                yield return new WaitForSeconds(transformationCoolDown/4);    
                cdBar.cdSlider.value += 15f;
                yield return new WaitForSeconds(transformationCoolDown/4);  
                cdBar.cdSlider.value += 15f;
                yield return new WaitForSeconds(transformationCoolDown/4);  
                cdBar.cdSlider.value += 15f;
                transformed = false;
                offCoolDown = true;
            }
        
    }
  
}
