using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class BulletModifierTimerToggle : BulletModifierTimer
{
    [SerializeField] private double onTime;
    [SerializeField] private double offTIme;
    [SerializeField] private bool isEnabled;

    public override void innerTick(){
        if(isEnabled){
            isEnabled = false;
            disable();
            cooldown = offTIme;
        }else{
            isEnabled = true;
            enable();
            cooldown = onTime;
        }
    }

}
