using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFlashlight : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        RaycastHit hitinfo;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hitinfo, 20f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * hitinfo.distance, Color.yellow);

            if (hitinfo.transform.tag == "SoundEffect")
            {
                if (!hitinfo.transform.GetComponent<AudioSource>().isPlaying)
                {
                    hitinfo.transform.GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}
