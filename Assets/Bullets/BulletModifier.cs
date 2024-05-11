using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletModifier : MonoBehaviour
{
    private Bullet parent;

    public void setParent(Bullet b){
        parent = b;
    }

    public void enable(){
        parent.activeMods.Add(this);
    }

    public void disable(){
        parent.activeMods.Remove(this);
    }

}
