using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public GameObject birdForm;
    public Vector3 offset;

    void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 camPos = transform.position;
            Vector3 desiredPos = player.transform.position;
            Vector3 altPos = birdForm.transform.position;
            Vector3 smoothedPos = Vector3.Lerp(camPos, desiredPos, 0.125f);
            Vector3 smoothedPosAlt = Vector3.Lerp(camPos, altPos, 0.125f);

            transform.position = new Vector3(smoothedPos.x, transform.position.y, transform.position.z);
            if (player.activeInHierarchy == false)
            {
                transform.position = new Vector3(smoothedPosAlt.x, transform.position.y, transform.position.z);
            }
        }
    }
}
