using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{

    // Bed parent class for Inheritance demo


    //Encapsulate with getters/setters
    [SerializeField] private string material;
    [SerializeField] private int price;
    [SerializeField] private string countryOfOrigin;
    [SerializeField] private string bedName;

    public DisplayBedInfo displayBedInfoScript;

    // Constructor to initialize the KingSizeBed
    public Bed(string material, int price, string countryOfOrigin, string bedName) 
    {
        this.material = material;
        this.price = Mathf.Max(0, price);
        this.countryOfOrigin = countryOfOrigin;
        this.bedName = bedName;
    }


    // Getter and setter for the 'material' property
    public string Material
    {
        get { return material; }
        private set { material = value; }
    }

    // Getter and setter for the 'price' property
    public int Price
    {
        get { return price; }
        set { price = Mathf.Max(0, value); } // ENCAPSULATION
    }

    // Getter and setter for the 'countryOfOrigin' property
    public string CountryOfOrigin
    {
        get { return countryOfOrigin; }
        private set { countryOfOrigin = value; }
    }


    // Getter and setter for the 'bedName' property
    public string BedName
    {
        get { return bedName; }
        private set { bedName = value; }
    }

    private void OnMouseDown()
    {
       

        displayBedInfoScript.UpdateTextValue(this.BedName + "\n $ " + this.Price + "\n Country of origin: " + this.CountryOfOrigin + "\n Material: " + this.Material);

    }

}
