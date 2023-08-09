using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayBedInfo : MonoBehaviour
{
    //ABSTRACTION
    public TextMeshProUGUI bedDisplayName;

    // Start is called before the first frame update
    void Start()
    {

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTextValue(string newValue)
    {
        // Update text with a new value
        bedDisplayName.text = newValue;
    }


}
