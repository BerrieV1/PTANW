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
   public GameObject doorLight;
   public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public  GameObject followCube;
    public GameObject map;
    private float timer = 0f;
    private float delay = 1f;
    public GameObject figures;

   void Start()
   {
        for (int i = 0; i < lights.transform.childCount; i++)
        {
            lights.transform.GetChild(i).GetComponent<Light>().enabled = false;
        }
        doorLight.GetComponent<Light>().enabled = false;
        appearOnGrab.SetActive(false);
   }

    void Update()
    {
        isGrabbed = grabInteractable.isSelected;
        if (isGrabbed)
        {
            appearOnGrab.SetActive(true);
            timer += Time.deltaTime;

            if (timer > delay)
            {
                for (int i = 0; i < lights.transform.childCount; i++)
                {
                    bool lightStatus = lights.transform.GetChild(i).GetComponent<Light>().enabled;
                    lights.transform.GetChild(i).GetComponent<Light>().enabled = !lightStatus;
                }
                timer = 0;
            }
            doorLight.GetComponent<Light>().enabled = true;
            animator1.Play("SinkAnimation");
            animator2.Play("RiseAnimation");
            animator3.Play("AppearingDoorAnimation");
            Destroy(followCube);
            Destroy(figures);
            map.SetActive(false);
        }
    }
}
