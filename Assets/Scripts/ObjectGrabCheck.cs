using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectGrabCheck : MonoBehaviour
{
   public bool isGrabbed = false;
   public XRGrabInteractable grabInteractable;
   public GameObject destroyOnGrab;
   public GameObject appearOnGrab;
   public GameObject lights;
   public Animator animator1;
    public Animator animator2;
    public  GameObject followCube;
    public GameObject map;

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
       //isGrabbed = grabInteractable.isSelected;

       if (isGrabbed)
       {
           appearOnGrab.SetActive(true);
           for (int i = 0; i < lights.transform.childCount; i++)
           {
               lights.transform.GetChild(i).GetComponent<Light>().enabled = true;
           }

            animator1.Play("SinkAnimation");
            animator2.Play("RiseAnimation");
            Destroy(followCube);
            map.SetActive(false);
       }
   }
}
