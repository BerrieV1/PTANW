using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectGrabCheck : MonoBehaviour
{
   private bool isGrabbed = false;
   public XRGrabInteractable grabInteractable;
   public GameObject destroyOnGrab;
   public GameObject appearOnGrab;
   public GameObject lights;
   public Animator animator;

   void Start()
   {
       for (int i = 0; i < lights.transform.childCount; i++)
       {
           lights.transform.GetChild(i).GetComponent<Light>().enabled = false;
       }
       appearOnGrab.SetActive(false);
   }

   void Update()
   {
       isGrabbed = grabInteractable.isSelected;

       if (isGrabbed)
       {
           appearOnGrab.SetActive(true);
           for (int i = 0; i < lights.transform.childCount; i++)
           {
               lights.transform.GetChild(i).GetComponent<Light>().enabled = true;
           }

           animator.Play("SinkAnimation");
       }
   }
}
