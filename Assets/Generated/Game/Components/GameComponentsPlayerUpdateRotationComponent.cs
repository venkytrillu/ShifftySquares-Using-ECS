//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.PlayerUpdateRotationComponent componentsPlayerUpdateRotation { get { return (Components.PlayerUpdateRotationComponent)GetComponent(GameComponentsLookup.ComponentsPlayerUpdateRotation); } }
    public bool hasComponentsPlayerUpdateRotation { get { return HasComponent(GameComponentsLookup.ComponentsPlayerUpdateRotation); } }

    public void AddComponentsPlayerUpdateRotation(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.ComponentsPlayerUpdateRotation;
        var component = (Components.PlayerUpdateRotationComponent)CreateComponent(index, typeof(Components.PlayerUpdateRotationComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceComponentsPlayerUpdateRotation(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.ComponentsPlayerUpdateRotation;
        var component = (Components.PlayerUpdateRotationComponent)CreateComponent(index, typeof(Components.PlayerUpdateRotationComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsPlayerUpdateRotation() {
        RemoveComponent(GameComponentsLookup.ComponentsPlayerUpdateRotation);
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

    static Entitas.IMatcher<GameEntity> _matcherComponentsPlayerUpdateRotation;

    public static Entitas.IMatcher<GameEntity> ComponentsPlayerUpdateRotation {
        get {
            if (_matcherComponentsPlayerUpdateRotation == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsPlayerUpdateRotation);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsPlayerUpdateRotation = matcher;
            }

            return _matcherComponentsPlayerUpdateRotation;
        }
    }
}
