using DM.Interfaces;
using UnityEngine;

namespace MD.Player
{
    public class MDSelectableController : ISelectableController
    {
        private ISelectable currentTargeting;


        public void Reset()
        {
            if (currentTargeting != null)
            {
                currentTargeting.OnDeHover();
            }
            currentTargeting = null;
        }
        public void Update(RaycastHit hit)
        {
            ISelectable selectable = hit.collider.GetComponent<ISelectable>();
            if (selectable != null)
            {
                if (selectable != currentTargeting)
                {
                    currentTargeting?.OnDeHover();
                }
                currentTargeting = selectable;
                currentTargeting.OnHover();
            }
            else
            {
                if (currentTargeting != null)
                {
                    currentTargeting.OnDeHover();
                    currentTargeting = null;
                }
            }


        }
    }
}