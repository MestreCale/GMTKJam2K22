using System.Collections;
using System.Collections.Generic;

namespace DM.Interfaces
{
    public interface ISelectable
{

    void OnSelect();
    void OnDeselect();
    void OnHover();
    void OnDeHover();
}
}