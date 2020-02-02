using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityNode
{
   
    public string FlavorText { get; set; }
    public BodyStats MainStress { get; set; }
    public BodyStats SideStress { get; set; }
    public string FlavorImage { get; set; }

    public ActivityNode(string flavorText, BodyStats mainStress, BodyStats sideStress, string flavorImage)
    {
        this.FlavorText = flavorText;
        this.MainStress = mainStress;
        this.SideStress = sideStress;
        this.FlavorImage = flavorImage;

    }

}
