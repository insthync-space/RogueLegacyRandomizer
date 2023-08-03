// RogueLegacyRandomizer - SkillType.cs
// Last Modified 2023-08-03 12:42 PM by 
// 
// This project is based on the modified disassembly of Rogue Legacy's engine, with permission to do so by its
// original creators. Therefore, the former creators' copyright notice applies to the original disassembly.
// 
// Original Source - © 2011-2018, Cellar Door Games Inc.
// Rogue Legacy™ is a trademark or registered trademark of Cellar Door Games Inc. All Rights Reserved.

namespace RogueLegacy.Enums;

public enum SkillType
{
    Null,
    Filler,
    HealthUp,
    InvulnTimeUp,
    DeathDodge,
    AttackUp,
    DownStrikeUp,
    CritChanceUp,
    CritDamageUp,
    MagicDamageUp,
    ManaUp,
    ManaCostDown,
    Smithy,
    Enchanter,
    Architect,
    EquipUp,
    ArmorUp,
    GoldGainUp,
    PricesDown,
    PotionUp,
    RandomChildren,
    LichUnlock,
    BankerUnlock,
    SpellswordUnlock,
    NinjaUnlock,
    KnightUnlock,
    KnightUp,
    MageUnlock,
    MageUp,
    AssassinUnlock,
    AssassinUp,
    BankerUp,
    BarbarianUnlock,
    BarbarianUp,
    LichUp,
    NinjaUp,
    SpellSwordUp,
    SuperSecret,
    Traitorous,
    Divider,
    AttackSpeedUp,
    InvulnerabilityAttackUp,
    HealthUpFinal,
    EquipUpFinal,
    DamageUpFinal,
    ManaUpFinal,
    XpGainUp,
    GoldFlatBonus,
    ManaRegenUp,
    Run,
    Block,
    Cartographer,
    EnvDamageDown,
    GoldLossDown,
    VampireUp,
    StoutHeart,
    QuickOfBreath,
    BornToRun,
    OutTheGate,
    Perfectionist,
    Guru,
    IronLung,
    SwordMaster,
    Tank,
    Vampire,
    SecondChance,
    PeaceOfMind,
    CartographyNinja,
    StrongMan,
    Suicidalist,
    CritBarbarian,
    Magician,
    Keymaster,
    OneTimeOnly,
    CuttingOutEarly,
    Quaffer,
    SpellSword,
    Sorcerer,
    WellEndowed,
    TreasureHunter,
    MortarMaster,
    ExplosiveExpert,
    Icicle,
    Ender,
    Manor,

    // Manor Pieces
    ManorGroundRoad,
    ManorMainBase,
    ManorMainWindowBottom,
    ManorMainWindowTop,
    ManorMainRoof,
    ManorLeftWingBase,
    ManorLeftWingWindow,
    ManorLeftWingRoof,
    ManorLeftBigBase,
    ManorLeftBigUpper1,
    ManorLeftBigUpper2,
    ManorLeftBigWindows,
    ManorLeftBigRoof,
    ManorLeftFarBase,
    ManorLeftFarRoof,
    ManorLeftExtension,
    ManorLeftTree1,
    ManorLeftTree2,
    ManorRightWingBase,
    ManorRightWingWindow,
    ManorRightWingRoof,
    ManorRightBigBase,
    ManorRightBigUpper,
    ManorRightBigRoof,
    ManorRightHighBase,
    ManorRightHighUpper,
    ManorRightHighTower,
    ManorRightExtension,
    ManorRightTree,
    ManorObservatoryBase,
    ManorObservatoryTelescope,

    // Unlocked shuffles
    BlacksmithSword,
    BlacksmithHelm,
    BlacksmithChest,
    BlacksmithLimbs,
    BlacksmithCape,
    EnchantressSword,
    EnchantressHelm,
    EnchantressChest,
    EnchantressLimbs,
    EnchantressCape,
}

public static class SkillExtensions
{
    public static float SkillStat(this SkillType skill)
    {
        // TODO: Remove magic values.
        return skill switch
        {
            SkillType.HealthUp              => Game.ScreenManager.Player.MaxHealth,
            SkillType.HealthUpFinal         => Game.ScreenManager.Player.MaxHealth,
            SkillType.InvulnTimeUp          => Game.ScreenManager.Player.InvincibilityTime,
            SkillType.DeathDodge            => SkillSystem.GetSkill(SkillType.DeathDodge).ModifierAmount * 100f,
            SkillType.AttackUp              => Game.ScreenManager.Player.Damage,
            SkillType.DamageUpFinal         => Game.ScreenManager.Player.Damage,
            SkillType.DownStrikeUp          => SkillSystem.GetSkill(SkillType.DownStrikeUp).ModifierAmount * 100f,
            SkillType.CritChanceUp          => Game.ScreenManager.Player.TotalCritChance,
            SkillType.CritDamageUp          => Game.ScreenManager.Player.TotalCriticalDamage * 100f,
            SkillType.MagicDamageUp         => Game.ScreenManager.Player.TotalMagicDamage,
            SkillType.ManaUp                => Game.ScreenManager.Player.MaxMana,
            SkillType.ManaUpFinal           => Game.ScreenManager.Player.MaxMana,
            SkillType.ManaCostDown          => SkillSystem.GetSkill(SkillType.ManaCostDown).ModifierAmount * 100f,
            SkillType.EquipUp               => Game.ScreenManager.Player.MaxWeight,
            SkillType.EquipUpFinal          => Game.ScreenManager.Player.MaxWeight,
            SkillType.ArmorUp               => Game.ScreenManager.Player.TotalArmor,
            SkillType.GoldGainUp            => Game.ScreenManager.Player.TotalGoldBonus,
            SkillType.PricesDown            => SkillSystem.GetSkill(SkillType.PricesDown).ModifierAmount * 100f,
            SkillType.PotionUp              => (0.1f + SkillSystem.GetSkill(SkillType.PotionUp).ModifierAmount) * 100f,
            SkillType.AttackSpeedUp         => SkillSystem.GetSkill(SkillType.AttackSpeedUp).ModifierAmount * 10f,
            SkillType.XpGainUp              => Game.ScreenManager.Player.TotalXPBonus,
            SkillType.ManaRegenUp           => Game.ScreenManager.Player.ManaGain,
            _                               => -1f
        };
    }
}