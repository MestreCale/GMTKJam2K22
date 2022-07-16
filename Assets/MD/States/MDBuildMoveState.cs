using DM.Interfaces;
using MD.Player;

namespace MD.States
{
    public class MDBuildMoveState : IPLayerState<MDPlayerController>
    {
        private ISelectableController _controller;

        public MDBuildMoveState(ISelectableController controller)
        {
            _controller = controller;
        }
        public void EnterState(MDPlayerController player)
        {
           
            
        }

        public void ExitState(MDPlayerController player)
        {
           
        }
    }
}