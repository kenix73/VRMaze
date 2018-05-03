using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public bool isLocked = true;
    private bool _opening = false;
    public AudioClip lockedSound;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 

    void Update() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (_opening && transform.position.y < 7.1f)
        {
            // keep moving up frame by frame.
            transform.Translate(0, 2.5f * Time.deltaTime, 0, Space.World);
        }

    }

    public void OnDoorClicked() {
        if (isLocked)
        {
            GetComponent<AudioSource>().clip = lockedSound;
            GetComponent<AudioSource>().Play();
            Debug.Log("Sorry man;  It's locked.");
            // play door locked sound -- don't open door.
        }
        else
        {
            _opening = true;
            GetComponent<AudioSource>().Play();
        }
        
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        isLocked = false;
        // You'll need to set "locked" to false here
    }
}
