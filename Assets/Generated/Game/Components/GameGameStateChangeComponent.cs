//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly GameStateChangeComponent gameStateChangeComponent = new GameStateChangeComponent();

    public bool isGameStateChange {
        get { return HasComponent(GameComponentsLookup.GameStateChange); }
        set {
            if (value != isGameStateChange) {
                var index = GameComponentsLookup.GameStateChange;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : gameStateChangeComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherGameStateChange;

    public static Entitas.IMatcher<GameEntity> GameStateChange {
        get {
            if (_matcherGameStateChange == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameStateChange);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameStateChange = matcher;
            }

            return _matcherGameStateChange;
        }
    }
}
