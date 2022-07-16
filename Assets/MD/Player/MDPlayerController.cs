using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using DM.Interfaces;
using StarterAssets;
using UnityEngine;

public enum AimState
{
    AimShoot,
    AimBuild
}

public class FiniteStateMachine<T> where T : IPLayer
{
    
}



namespace MD.Player
{

  

    [RequireComponent(typeof(MDPlayerInput))]
    public class MDPlayerController : ThirdPersonController, IPLayer
{ 
    
    [Header("Shooting Dependencies")]
    [SerializeField] private CinemachineVirtualCamera aimCamera;

    [SerializeField] private GameObject crossHair;

    private ISelectableController _selectableController;

    private AimState _aimState;

    public DummyTurret turretToPlace;
    private Camera mainCamera;

    private IPLayerState<MDPlayerController> currentState;
    private MDPlayerShootingState _playerShootingState;
    private MDPlayerBuildState _playerBuildState;

    public MDPlayerInput getInput()
    {
        return _input as MDPlayerInput;
    }

    protected override void Start()
    {
        base.Start();

        _selectableController = new MDSelectableController();
        mainCamera = FindObjectOfType<Camera>();
        _input = GetComponent<MDPlayerInput>();
        if (_input is MDPlayerInput playerInput)
        {
            playerInput.OnStateBuild += SwitchToBuilding;
            playerInput.OnStateShoot += SwitchToShooting;
        }

        _playerBuildState = new MDPlayerBuildState(mainCamera,turretToPlace);
        _playerShootingState = new MDPlayerShootingState(_selectableController, mainCamera);
        currentState = _playerBuildState;
    }

    private void OnDestroy()
    {
        if (_input is MDPlayerInput playerInput)
        {
            playerInput.OnStateBuild -= SwitchToBuilding;
            playerInput.OnStateShoot -= SwitchToShooting;
        }
    }



    private void SwwitchToState(IPLayerState<MDPlayerController> state)
    {
        currentState.ExitState(this);
        currentState = state;
    }
    private void SwitchToShooting()
    {
        SwwitchToState(_playerShootingState);
    }

    private void SwitchToBuilding()
    {
        SwwitchToState(_playerBuildState);
      
    }
    private void OnAim()
    {
        aimCamera.gameObject.SetActive(true);
        crossHair.gameObject.SetActive(true);
        
        currentState.EnterState(this);

      
      
    }

    private void OnDeAim()
    {
        aimCamera.gameObject.SetActive(false);
        crossHair.gameObject.SetActive(false);

        currentState.ExitState(this);
    }


    protected override void Update()
    {
        base.Update();
        
       
        
        if (_input.aim && Grounded) OnAim();
        else OnDeAim();
        
        
        
           
       
    }
}
}