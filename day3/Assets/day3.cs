using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour

{
    string heroname = "spiderman";
    int heropower = 55;

    string villianname = "joker";
    int villianpower = 78;

    float playerspeed = 8.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (heropower < villianpower)
        {
            print("villianpower");  
        } 
        else if (villianpower == villianpower)
        {
            print("villian power equal hero power ");
        }
        else
        {
            print("heropower");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void setspeed(float newspeed)
    {
        print(playerspeed);
            newspeed = playerspeed;
        print(playerspeed);
    }

}
