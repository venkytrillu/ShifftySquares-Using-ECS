//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ComponentsUpdateRotationListenerComponent componentsUpdateRotationListener { get { return (ComponentsUpdateRotationListenerComponent)GetComponent(GameComponentsLookup.ComponentsUpdateRotationListener); } }
    public bool hasComponentsUpdateRotationListener { get { return HasComponent(GameComponentsLookup.ComponentsUpdateRotationListener); } }

    public void AddComponentsUpdateRotationListener(System.Collections.Generic.List<IComponentsUpdateRotationListener> newValue) {
        var index = GameComponentsLookup.ComponentsUpdateRotationListener;
        var component = (ComponentsUpdateRotationListenerComponent)CreateComponent(index, typeof(ComponentsUpdateRotationListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceComponentsUpdateRotationListener(System.Collections.Generic.List<IComponentsUpdateRotationListener> newValue) {
        var index = GameComponentsLookup.ComponentsUpdateRotationListener;
        var component = (ComponentsUpdateRotationListenerComponent)CreateComponent(index, typeof(ComponentsUpdateRotationListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsUpdateRotationListener() {
        RemoveComponent(GameComponentsLookup.ComponentsUpdateRotationListener);
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

    static Entitas.IMatcher<GameEntity> _matcherComponentsUpdateRotationListener;

    public static Entitas.IMatcher<GameEntity> ComponentsUpdateRotationListener {
        get {
            if (_matcherComponentsUpdateRotationListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsUpdateRotationListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsUpdateRotationListener = matcher;
            }

            return _matcherComponentsUpdateRotationListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddComponentsUpdateRotationListener(IComponentsUpdateRotationListener value) {
        var listeners = hasComponentsUpdateRotationListener
            ? componentsUpdateRotationListener.value
            : new System.Collections.Generic.List<IComponentsUpdateRotationListener>();
        listeners.Add(value);
        ReplaceComponentsUpdateRotationListener(listeners);
    }

    public void RemoveComponentsUpdateRotationListener(IComponentsUpdateRotationListener value, bool removeComponentWhenEmpty = true) {
        var listeners = componentsUpdateRotationListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveComponentsUpdateRotationListener();
        } else {
            ReplaceComponentsUpdateRotationListener(listeners);
        }
    }
}
