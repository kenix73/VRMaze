using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject keyPoofPrefab;
    public GameObject mazeDoor;
    public bool keyCollected = false;
    //Create a reference to the KeyPoofPrefab and Door

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy

        keyCollected = true; // not used, but did it because it asked.  The door is unlocked when the key is picked up, os this ia a no-op.
        Instantiate(keyPoofPrefab, transform.position, Quaternion.Euler(270, 0, 0));
        DestroyObject(gameObject);
        mazeDoor.GetComponent<Door>().Unlock();
    }

}
