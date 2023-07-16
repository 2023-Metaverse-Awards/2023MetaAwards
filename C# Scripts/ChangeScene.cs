using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string NextLevel; // The name of the scene to load

    void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is your character
        if (other.gameObject.tag == "Character")
        {
            SceneManager.LoadScene(NextLevel);
        }
    }
}