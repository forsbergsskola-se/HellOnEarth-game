using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeForm : MonoBehaviour
{
    public GameObject oden;
    public GameObject crow;

    public bool transformed;
    public bool transInProgress;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            StartCoroutine(TransformPlayer());
        }
    }

    IEnumerator TransformPlayer()
    {
        if (transInProgress)
        {
            yield return new WaitForSeconds(3);
            transInProgress = false;
        }
        else
        {
            if (!transformed)
            {
                transformed = true;
                oden.SetActive(false);
                crow.SetActive(true);
                transInProgress = true;
                yield return new WaitForSeconds(3);
            }
            else if (transformed)
            {
                transformed = false;
                oden.SetActive(true);
                crow.SetActive(false);
                transInProgress = true;
                yield return new WaitForSeconds(3);
            }
        }
    }
}
