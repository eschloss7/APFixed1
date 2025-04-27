using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfAcorns { get; private set; }

    public UnityEvent<PlayerInventory> OnAcornCollected;


    

    public void AcornCollected()
    {
        NumberOfAcorns++;
        OnAcornCollected.Invoke(this);
        
    }

}
