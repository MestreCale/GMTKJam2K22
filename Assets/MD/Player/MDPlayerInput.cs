using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;


namespace MD.Player
{
   
public class MDPlayerInput : StarterAssetsInputs
{

    public event Action OnStateShoot;
    public event Action OnStateBuild;
   
    public void OnAim(InputValue value)
    {
        AimInput(value.isPressed);
    }

    public void OnFire(InputValue value)
    {
        ShootInput(value.isPressed);
    }
    public void OnSetStateAim(InputValue value)
    {
        OnStateShoot?.Invoke();
    }
    public void OnSetStateBuild(InputValue value)
    {
        OnStateBuild?.Invoke();
    }

    public void ShootInput(bool newShoot)
    {
        fire = newShoot;   
    }

    public void AimInput(bool newAimState)
    {
        aim = newAimState;   
    }

   
 
   
   
}
}