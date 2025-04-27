using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornCollector : MonoBehaviour
{
    public int acornsCollected = 0;
    public int acornsNeeded = 5;
    public GameObject door; // Assign the door GameObject in the Inspector

    private bool doorOpened = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Acorn"))
        {
            Destroy(other.gameObject); // Remove the acorn
            acornsCollected++;

            if (acornsCollected >= acornsNeeded && !doorOpened)
            {
                OpenDoor();
            }
        }
    }

    void OpenDoor()
    {
        doorOpened = true;
        // Example action: Disable the door (make it disappear)
        door.SetActive(false);

        // You can replace this with an animation, sound, etc.
        Debug.Log("Door opened!");
    }
}
