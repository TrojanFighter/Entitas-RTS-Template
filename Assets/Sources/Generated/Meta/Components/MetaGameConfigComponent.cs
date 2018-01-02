//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaContext {

    public MetaEntity gameConfigEntity { get { return GetGroup(MetaMatcher.GameConfig).GetSingleEntity(); } }
    public GameConfigComponent gameConfig { get { return gameConfigEntity.gameConfig; } }
    public bool hasGameConfig { get { return gameConfigEntity != null; } }

    public MetaEntity SetGameConfig(Configs.SO.GameConfig newValue) {
        if (hasGameConfig) {
            throw new Entitas.EntitasException("Could not set GameConfig!\n" + this + " already has an entity with GameConfigComponent!",
                "You should check if the context already has a gameConfigEntity before setting it or use context.ReplaceGameConfig().");
        }
        var entity = CreateEntity();
        entity.AddGameConfig(newValue);
        return entity;
    }

    public void ReplaceGameConfig(Configs.SO.GameConfig newValue) {
        var entity = gameConfigEntity;
        if (entity == null) {
            entity = SetGameConfig(newValue);
        } else {
            entity.ReplaceGameConfig(newValue);
        }
    }

    public void RemoveGameConfig() {
        gameConfigEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaEntity {

    public GameConfigComponent gameConfig { get { return (GameConfigComponent)GetComponent(MetaComponentsLookup.GameConfig); } }
    public bool hasGameConfig { get { return HasComponent(MetaComponentsLookup.GameConfig); } }

    public void AddGameConfig(Configs.SO.GameConfig newValue) {
        var index = MetaComponentsLookup.GameConfig;
        var component = CreateComponent<GameConfigComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameConfig(Configs.SO.GameConfig newValue) {
        var index = MetaComponentsLookup.GameConfig;
        var component = CreateComponent<GameConfigComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameConfig() {
        RemoveComponent(MetaComponentsLookup.GameConfig);
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
public sealed partial class MetaMatcher {

    static Entitas.IMatcher<MetaEntity> _matcherGameConfig;

    public static Entitas.IMatcher<MetaEntity> GameConfig {
        get {
            if (_matcherGameConfig == null) {
                var matcher = (Entitas.Matcher<MetaEntity>)Entitas.Matcher<MetaEntity>.AllOf(MetaComponentsLookup.GameConfig);
                matcher.componentNames = MetaComponentsLookup.componentNames;
                _matcherGameConfig = matcher;
            }

            return _matcherGameConfig;
        }
    }
}
