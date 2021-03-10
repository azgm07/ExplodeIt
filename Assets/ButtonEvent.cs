using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonEvent : Button
{
    //public GameObject target;
    public bool held = false;
    public bool fire = false;
 
    public override void OnPointerDown(PointerEventData data)
    {
        held = true;
    }
 
    public override void OnPointerUp(PointerEventData data)
    {
        held = false;
        fire = true;
    }

}
