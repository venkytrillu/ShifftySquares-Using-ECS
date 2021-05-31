//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.PlayerUpdatePositionComponent componentsPlayerUpdatePosition { get { return (Components.PlayerUpdatePositionComponent)GetComponent(GameComponentsLookup.ComponentsPlayerUpdatePosition); } }
    public bool hasComponentsPlayerUpdatePosition { get { return HasComponent(GameComponentsLookup.ComponentsPlayerUpdatePosition); } }

    public void AddComponentsPlayerUpdatePosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.ComponentsPlayerUpdatePosition;
        var component = (Components.PlayerUpdatePositionComponent)CreateComponent(index, typeof(Components.PlayerUpdatePositionComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceComponentsPlayerUpdatePosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.ComponentsPlayerUpdatePosition;
        var component = (Components.PlayerUpdatePositionComponent)CreateComponent(index, typeof(Components.PlayerUpdatePositionComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsPlayerUpdatePosition() {
        RemoveComponent(GameComponentsLookup.ComponentsPlayerUpdatePosition);
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

    static Entitas.IMatcher<GameEntity> _matcherComponentsPlayerUpdatePosition;

    public static Entitas.IMatcher<GameEntity> ComponentsPlayerUpdatePosition {
        get {
            if (_matcherComponentsPlayerUpdatePosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsPlayerUpdatePosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsPlayerUpdatePosition = matcher;
            }

            return _matcherComponentsPlayerUpdatePosition;
        }
    }
}
