

using UnityEngine;

namespace DM.Interfaces
{
    public interface IPlaceable
    {

        void StartPlacing(Vector3 position);
        void EndPlacing();
        void Place();
    

    }
}