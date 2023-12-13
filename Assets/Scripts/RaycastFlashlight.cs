using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFlashlight : MonoBehaviour
{
    private bool isLookingAtObject = false;
    private float cooldownTime = 20f;
    private float cooldownTimer = 0f;

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
                if (!isLookingAtObject && cooldownTimer <= 0f)
                {
                    hitinfo.transform.GetComponent<AudioSource>().Play();
                    isLookingAtObject = true;
                    cooldownTimer = cooldownTime;
                }
            }
            else
            {
                if (isLookingAtObject)
                {
                    isLookingAtObject = false;
                }
            }
        }
        else
        {
            if (isLookingAtObject)
            {
                isLookingAtObject = false;
            }
        }

        if (cooldownTimer > 0f)
        {
            cooldownTimer -= Time.deltaTime;
        }
    }
}
