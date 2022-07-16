using UnityEngine;

namespace DM.Interfaces
{
    public interface ISelectableController
    {
        public void Update(RaycastHit hit);
        public void Reset();
    }
}