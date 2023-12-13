using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFlashlight : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out RaycastHit hitinfo, 20f))
        {
            audioSource.Play();
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * hitinfo.distance, Color.red);

        }
    }
}
