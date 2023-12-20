using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public string sceneName;  // The name of the scene to load

    // This function is called when a collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided and loading scene");
        Debug.Log(sceneName);
        Debug.Log(collision.transform.tag);

        if(collision.transform.tag == "Player")
        {
            Debug.Log("teleporting");
            LoadScene();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided and loading scene");
        if (other.transform.tag == "Player")
        {
            Debug.Log("teleporting");
            LoadScene();
        }
    }

    // Load the specified scene
    private void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    private void LoadBackupScene()
    {
        SceneManager.LoadScene("BackupPhilippeScene");
    }

    private void LoadIntroScene()
    {
        SceneManager.LoadScene("Intro");
    }



}
