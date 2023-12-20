using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ElevatorGrabCheck : MonoBehaviour
{
    public AudioSource clapping;
    public Light corwdLight;
    public bool isGrabbed = false;
    public XRGrabInteractable grabInteractable;
    public GameObject army;
    void Start()
    {
        
    }

    void Update()
    {
        isGrabbed = grabInteractable.isSelected;
        if (isGrabbed)
        {
            if (!clapping.isPlaying)
            {
                clapping.Play();
            }
            corwdLight.enabled = true;

            GameObject[] clowns = GameObject.FindGameObjectsWithTag("Clown");
            foreach (GameObject clown in clowns)
            {
                Animator animator = clown.GetComponent<Animator>();

                if (animator != null)
                {
                    animator.SetTrigger("Clapping");
                }
            }
        }
    }
}
