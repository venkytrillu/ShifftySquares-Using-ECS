//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class DebugEntity {

    static readonly Components.DestroyComponent componentsDestroyComponent = new Components.DestroyComponent();

    public bool isComponentsDestroy {
        get { return HasComponent(DebugComponentsLookup.ComponentsDestroy); }
        set {
            if (value != isComponentsDestroy) {
                var index = DebugComponentsLookup.ComponentsDestroy;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : componentsDestroyComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class DebugEntity : IComponentsDestroyEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class DebugMatcher {

    static Entitas.IMatcher<DebugEntity> _matcherComponentsDestroy;

    public static Entitas.IMatcher<DebugEntity> ComponentsDestroy {
        get {
            if (_matcherComponentsDestroy == null) {
                var matcher = (Entitas.Matcher<DebugEntity>)Entitas.Matcher<DebugEntity>.AllOf(DebugComponentsLookup.ComponentsDestroy);
                matcher.componentNames = DebugComponentsLookup.componentNames;
                _matcherComponentsDestroy = matcher;
            }

            return _matcherComponentsDestroy;
        }
    }
}