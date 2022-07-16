using DM.Interfaces;
using MD.Player;
using UnityEngine;

public static class LayerMasks
{
    public static LayerMask placeableLayerMask = LayerMask.GetMask("Placeables");
}
public class MDPlayerBuildState : IPLayerState<MDPlayerController>
{
  
    private Camera _camera;
    private IPlaceable toPlace;
    
    public MDPlayerBuildState(Camera camera,IPlaceable toPlace)
    {
       
        _camera = camera;
        this.toPlace = toPlace;
    }
    public void EnterState(MDPlayerController player)
    {
      
        Ray ray = new Ray(_camera.transform.position, _camera.transform.forward);
        
        if (Physics.Raycast(ray, out RaycastHit hit, 100, ~LayerMasks.placeableLayerMask))
        {
            toPlace.StartPlacing(hit.point);
            MDPlayerInput input = player.getInput();
            if (input)
            {
                if (input.fire)
                {

                    toPlace.Place();
                }
              
            }
        
        }
        else
        {
           
           
        }
        
    }

    public void ExitState(MDPlayerController player)
    {
        toPlace.EndPlacing();
        
    }
}