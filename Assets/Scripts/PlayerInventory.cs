using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfAcorns { get; private set; }

    

    public void AcornCollected()
    {
        NumberOfAcorns++;
        
    }

}
