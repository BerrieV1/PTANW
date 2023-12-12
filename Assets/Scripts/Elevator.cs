using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    public float speed; // The speed at which the object moves
    private Vector3 targetPosition; // The target position of the object
    public GameObject elevatorObject;
    bool trigger = false;
    private AudioSource musicChanger;
    public AudioClip clip;
    GameObject audioMainLoop;


    void Start()
    {
        // Set the target position of the object
        targetPosition = new Vector3(elevatorObject.transform.position.x, 1543, elevatorObject.transform.position.z);
        audioMainLoop = GameObject.Find("Audio_Main_Loop");
        musicChanger = audioMainLoop.GetComponent<AudioSource>();
    }

    void Update()
    {
        if(trigger)
        {
            if(elevatorObject.transform.position.y < 1543)
            {
                elevatorObject.transform.position += new Vector3(0, 0.04f, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        musicChanger.clip = clip;
        TriggerElevator();
        trigger = true;
    }

    // Define the function to trigger the elevator.
    private void TriggerElevator()
    {
        // Your logic to trigger the elevator goes here.
        Debug.Log("Elevator button pressed!");
        
    }
}
