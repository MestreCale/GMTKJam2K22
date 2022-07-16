
namespace DM.Interfaces
{
    public interface IPLayerState<in T> where T : IPLayer
{

    void EnterState(T player);
    void ExitState(T player);

}}