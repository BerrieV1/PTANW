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
    public AudioClip clip;


    void Start()
    {
        // Set the target position of the object
        targetPosition = new Vector3(elevatorObject.transform.position.x, 1543, elevatorObject.transform.position.z);
    }

    void Update()
    {
        if(trigger)
        {
            if(elevatorObject.transform.position.y < 139.5f)
            {
                Debug.Log("elevating");
                MoveElevatorUp();
            } else
            {
                ChangeMusic.StopMusic();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        ChangeMusic.ChangeAudioClip(clip);
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
        elevatorObject.transform.position += new Vector3(0, 90f, 0) * speed * Time.deltaTime;
    }
}
