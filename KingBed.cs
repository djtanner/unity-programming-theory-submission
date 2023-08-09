using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingBed : Bed
{
    private int extraWidth;

    //INHERITANCE

    // Constructor to initialize the KingSizeBed
    public KingBed(string material, int price, string countryOfOrigin, string bedName, int extraWidth) : base(material, price, countryOfOrigin, bedName)
    {
        this.extraWidth = extraWidth;
    }

    // Start is called before the first frame update
    void Start()
    {

        extraWidth = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //POLYMORPHISM
    public int GetExtraWidth()
    {
        return extraWidth;
    }

  
}
