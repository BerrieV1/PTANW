using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    public float speed; // The speed at which the object moves
    private Vector3 targetPosition; // The target position of the object
    public GameObject elevatorObject;
    bool trigger = false;
    private ChangeMusic musicChanger;
    public AudioClip clipElevator;
    public AudioClip clipArrived;
    private bool playedElevatorSound = false;
    public GameObject xrRig;
    public GameObject character;
    private CharacterController controller;


    void Start()
    {
        // Set the target position of the object
        targetPosition = new Vector3(elevatorObject.transform.position.x, 1543, elevatorObject.transform.position.z);
        controller = character.GetComponent<CharacterController>();
    }

    void Update()
    {
        if(trigger)
        {
            controller.enabled = false;
            if(elevatorObject.transform.position.y < 105.339f)
            {
                Debug.Log("elevating");
                MoveElevatorUp();
                MoveXrRig();
            } else if(!playedElevatorSound)
            {
                ChangeMusic.StopMusic();
                ChangeMusic.PlayArrivalSound(clipArrived);
                playedElevatorSound = true;
                controller.enabled = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        ChangeMusic.ChangeAudioClip(clipElevator);
        TriggerElevator();
        trigger = true;
    }

    // Define the function to trigger the elevator.
    private void TriggerElevator()
    {
        // Your logic to trigger the elevator goes here.
        Debug.Log("Elevator button pressed!");
        
    }

    private void MoveElevatorUp()
    {
        // Move the elevator up by 0.01 units per frame
        elevatorObject.transform.position += new Vector3(0, 150f, 0) * speed * Time.deltaTime;
    }
    private void MoveXrRig()
    {
        // Move the elevator up by 0.01 units per frame
        xrRig.transform.position += new Vector3(0, 150f, 0) * speed * Time.deltaTime;
    }
}
