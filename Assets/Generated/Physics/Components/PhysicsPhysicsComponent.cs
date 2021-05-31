//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PhysicsContext {

    public PhysicsEntity physicsEntity { get { return GetGroup(PhysicsMatcher.Physics).GetSingleEntity(); } }

    public bool isPhysics {
        get { return physicsEntity != null; }
        set {
            var entity = physicsEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isPhysics = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PhysicsEntity {

    static readonly PhysicsComponent physicsComponent = new PhysicsComponent();

    public bool isPhysics {
        get { return HasComponent(PhysicsComponentsLookup.Physics); }
        set {
            if (value != isPhysics) {
                var index = PhysicsComponentsLookup.Physics;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : physicsComponent;

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
public sealed partial class PhysicsMatcher {

    static Entitas.IMatcher<PhysicsEntity> _matcherPhysics;

    public static Entitas.IMatcher<PhysicsEntity> Physics {
        get {
            if (_matcherPhysics == null) {
                var matcher = (Entitas.Matcher<PhysicsEntity>)Entitas.Matcher<PhysicsEntity>.AllOf(PhysicsComponentsLookup.Physics);
                matcher.componentNames = PhysicsComponentsLookup.componentNames;
                _matcherPhysics = matcher;
            }

            return _matcherPhysics;
        }
    }
}
