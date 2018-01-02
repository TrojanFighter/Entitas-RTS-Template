//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly MouseScrollDownComponent mouseScrollDownComponent = new MouseScrollDownComponent();

    public bool isMouseScrollDown {
        get { return HasComponent(InputComponentsLookup.MouseScrollDown); }
        set {
            if (value != isMouseScrollDown) {
                var index = InputComponentsLookup.MouseScrollDown;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : mouseScrollDownComponent;

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

    static Entitas.IMatcher<InputEntity> _matcherMouseScrollDown;

    public static Entitas.IMatcher<InputEntity> MouseScrollDown {
        get {
            if (_matcherMouseScrollDown == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.MouseScrollDown);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherMouseScrollDown = matcher;
            }

            return _matcherMouseScrollDown;
        }
    }
}
