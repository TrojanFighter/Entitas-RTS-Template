//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly RightMouseButtonUpComponent rightMouseButtonUpComponent = new RightMouseButtonUpComponent();

    public bool isRightMouseButtonUp {
        get { return HasComponent(InputComponentsLookup.RightMouseButtonUp); }
        set {
            if (value != isRightMouseButtonUp) {
                var index = InputComponentsLookup.RightMouseButtonUp;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : rightMouseButtonUpComponent;

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
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherRightMouseButtonUp;

    public static Entitas.IMatcher<InputEntity> RightMouseButtonUp {
        get {
            if (_matcherRightMouseButtonUp == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.RightMouseButtonUp);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherRightMouseButtonUp = matcher;
            }

            return _matcherRightMouseButtonUp;
        }
    }
}
