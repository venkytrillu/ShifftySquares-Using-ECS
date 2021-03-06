//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ComponentsPlayerUpdateRotationListenerComponent componentsPlayerUpdateRotationListener { get { return (ComponentsPlayerUpdateRotationListenerComponent)GetComponent(GameComponentsLookup.ComponentsPlayerUpdateRotationListener); } }
    public bool hasComponentsPlayerUpdateRotationListener { get { return HasComponent(GameComponentsLookup.ComponentsPlayerUpdateRotationListener); } }

    public void AddComponentsPlayerUpdateRotationListener(System.Collections.Generic.List<IComponentsPlayerUpdateRotationListener> newValue) {
        var index = GameComponentsLookup.ComponentsPlayerUpdateRotationListener;
        var component = (ComponentsPlayerUpdateRotationListenerComponent)CreateComponent(index, typeof(ComponentsPlayerUpdateRotationListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceComponentsPlayerUpdateRotationListener(System.Collections.Generic.List<IComponentsPlayerUpdateRotationListener> newValue) {
        var index = GameComponentsLookup.ComponentsPlayerUpdateRotationListener;
        var component = (ComponentsPlayerUpdateRotationListenerComponent)CreateComponent(index, typeof(ComponentsPlayerUpdateRotationListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsPlayerUpdateRotationListener() {
        RemoveComponent(GameComponentsLookup.ComponentsPlayerUpdateRotationListener);
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

    static Entitas.IMatcher<GameEntity> _matcherComponentsPlayerUpdateRotationListener;

    public static Entitas.IMatcher<GameEntity> ComponentsPlayerUpdateRotationListener {
        get {
            if (_matcherComponentsPlayerUpdateRotationListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsPlayerUpdateRotationListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsPlayerUpdateRotationListener = matcher;
            }

            return _matcherComponentsPlayerUpdateRotationListener;
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

    public void AddComponentsPlayerUpdateRotationListener(IComponentsPlayerUpdateRotationListener value) {
        var listeners = hasComponentsPlayerUpdateRotationListener
            ? componentsPlayerUpdateRotationListener.value
            : new System.Collections.Generic.List<IComponentsPlayerUpdateRotationListener>();
        listeners.Add(value);
        ReplaceComponentsPlayerUpdateRotationListener(listeners);
    }

    public void RemoveComponentsPlayerUpdateRotationListener(IComponentsPlayerUpdateRotationListener value, bool removeComponentWhenEmpty = true) {
        var listeners = componentsPlayerUpdateRotationListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveComponentsPlayerUpdateRotationListener();
        } else {
            ReplaceComponentsPlayerUpdateRotationListener(listeners);
        }
    }
}
