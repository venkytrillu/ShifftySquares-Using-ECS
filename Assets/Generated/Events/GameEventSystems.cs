//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameEventSystems : Feature {

    public GameEventSystems(Contexts contexts) {
        Add(new ComponentsBlockUpdatePositionEventSystem(contexts)); // priority: 0
        Add(new ComponentsBlockUpdateRotationEventSystem(contexts)); // priority: 0
        Add(new ComponentsPlayerUpdatePositionEventSystem(contexts)); // priority: 0
        Add(new ComponentsPlayerUpdateRotationEventSystem(contexts)); // priority: 0
        Add(new ComponentsUpdatePositionEventSystem(contexts)); // priority: 0
        Add(new ComponentsUpdateRotationEventSystem(contexts)); // priority: 0
        Add(new ComponentsUpdateScaleEventSystem(contexts)); // priority: 0
    }
}
