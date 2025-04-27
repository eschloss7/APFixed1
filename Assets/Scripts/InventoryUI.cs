using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI acornText;

    // Start is called before the first frame update
    void Start()
    {
        acornText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateAcornText(PlayerInventory playerInventory)
    {
        acornText.text = playerInventory.NumberOfAcorns.ToString();
    }
}
