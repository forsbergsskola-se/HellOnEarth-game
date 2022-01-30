using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeForm : MonoBehaviour
{
    public GameObject oden;
    public GameObject crow;
    [SerializeField] private ParticleSystem ps;
    private bool offCoolDown = true;

    public bool transformed;
    public bool transInProgress;

    [SerializeField] private float TransformationCoolDown = 3;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2") && offCoolDown)
        {
            StartCoroutine(TransformPlayer());
            offCoolDown = false;
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
        if (transInProgress)
        {
            yield return new WaitForSeconds(TransformationCoolDown);
            offCoolDown = true;
            transInProgress = false;
        }
        else
        {
            if (!transformed)
            {
                transformed = true;
                ps.Play();
                oden.SetActive(false);
                crow.SetActive(true);
                transInProgress = true;
                yield return new WaitForSeconds(TransformationCoolDown);
                offCoolDown = true;
            }
            else if (transformed)
            {
                transformed = false;
                ps.Play();
                oden.SetActive(true);
                crow.SetActive(false);
                transInProgress = true;
                yield return new WaitForSeconds(TransformationCoolDown);
                offCoolDown = true;
            }
        }
    }
}
