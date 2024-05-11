using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BulletModifierTimer : BulletModifier
{
    [SerializeField] protected double cooldown;
    [SerializeField] private double currTime;

    [SerializeField] private double onTime;
    [SerializeField] private double offTIme;
    [SerializeField] private bool isEnabled;

    void Update(){
        currTime += Time.deltaTime;
        if(currTime >= cooldown){
            currTime = 0;
            toggle();
        }
    }

    private void toggle(){
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
