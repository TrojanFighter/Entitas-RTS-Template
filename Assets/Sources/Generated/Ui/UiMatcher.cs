//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class UiMatcher {

    public static Entitas.IAllOfMatcher<UiEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<UiEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<UiEntity> AllOf(params Entitas.IMatcher<UiEntity>[] matchers) {
          return Entitas.Matcher<UiEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<UiEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<UiEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<UiEntity> AnyOf(params Entitas.IMatcher<UiEntity>[] matchers) {
          return Entitas.Matcher<UiEntity>.AnyOf(matchers);
    }
}
