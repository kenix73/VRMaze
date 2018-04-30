using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public Transform poof_prefab;
    
    //Create a reference to the CoinPoofPrefab

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

        Instantiate(poof_prefab, transform.position, Quaternion.Euler(270,0,0));
        DestroyObject(gameObject);

    }

}
