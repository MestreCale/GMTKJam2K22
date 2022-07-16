using DM.Interfaces;
using MD.Player;
using UnityEngine;

public class MDPlayerShootingState : IPLayerState<MDPlayerController>
{
    
    private ISelectableController _selectableController;
    private Camera _camera;
    
    public MDPlayerShootingState(ISelectableController selectableController,Camera camera)
    {
        _selectableController = selectableController;
        _camera = camera;
    }
    
    public void EnterState(MDPlayerController player)
    {
        Ray ray = new Ray(_camera.transform.position, _camera.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, 100))
        {
            
            _selectableController.Update(hit);
         
        
        }
        else
        {
            _selectableController.Reset();
        }
        
    }

    public void ExitState(MDPlayerController player)
    {
        _selectableController.Reset();
    }
}