using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITankControl : ITankBody, ITankGun
{
    
}

public interface ITankBody
{
    void Move(double Xinput, double Yinput);
}

public interface ITankGun
{
    void Aim(double Xinput, double Yinput);
    void Shoot();
}