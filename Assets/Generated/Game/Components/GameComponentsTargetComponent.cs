//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Components.TargetComponent componentsTargetComponent = new Components.TargetComponent();

    public bool isComponentsTarget {
        get { return HasComponent(GameComponentsLookup.ComponentsTarget); }
        set {
            if (value != isComponentsTarget) {
                var index = GameComponentsLookup.ComponentsTarget;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : componentsTargetComponent;

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
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherComponentsTarget;

    public static Entitas.IMatcher<GameEntity> ComponentsTarget {
        get {
            if (_matcherComponentsTarget == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsTarget);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsTarget = matcher;
            }

            return _matcherComponentsTarget;
        }
    }
}