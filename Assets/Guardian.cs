using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardian : MonoBehaviour {

    public int coinsCollected = 0;

    
    public void GuardianClicked()
    {
        Debug.Log("Click Detected: " + coinsCollected.ToString());
        
        if (coinsCollected >= 3)
        {
            GetComponent<Animator>().SetTrigger("PlayYes");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
            AudioSource plateSound = GetComponent<AudioSource>();
            plateSound.PlayOneShot(plateSound.clip);

        }
        else
        { 
            GetComponent<Animator>().SetTrigger("PlayNo");
        }
    }
    public void AddCoin()
    {
        coinsCollected++;
    }
}
