//  RogueLegacyRandomizer - EquipmentAbility.cs
//  Last Modified 2023-10-24 4:05 PM
//
//  This project is based on the modified disassembly of Rogue Legacy's engine, with permission to do so by its
//  original creators. Therefore, the former creators' copyright notice applies to the original disassembly.
//
//  Original Source - © 2011-2018, Cellar Door Games Inc.
//  Rogue Legacy™ is a trademark or registered trademark of Cellar Door Games Inc. All Rights Reserved.

using System;
using Randomizer;

namespace RogueLegacy.Enums;

public enum EquipmentAbility
{
    Vault,
    Sprint,
    Vampire,
    Sky,
    Siphon,
    Retaliation,
    Bounty,
    Haste,
    Curse,
    Grace,
    Balance,
    ArchitectFee         = 20,
    NewGamePlusGoldBonus = 21
}

public static class EquipmentAbilityExtensions
{
    public static string Name(this EquipmentAbility ability)
    {
        return ability switch
        {
            EquipmentAbility.Vault                => "Vault",
            EquipmentAbility.Sprint               => "Sprint",
            EquipmentAbility.Vampire              => "Vampire",
            EquipmentAbility.Sky                  => "Sky",
            EquipmentAbility.Siphon               => "Siphon",
            EquipmentAbility.Retaliation          => "Retaliation",
            EquipmentAbility.Bounty               => "Bounty",
            EquipmentAbility.Haste                => "Haste",
            EquipmentAbility.Curse                => "Curse",
            EquipmentAbility.Grace                => "Grace",
            EquipmentAbility.Balance              => "Balance",
            EquipmentAbility.ArchitectFee         => "Architect's Fee",
            EquipmentAbility.NewGamePlusGoldBonus => "NG+ Bonus",
            _                                     => throw new ArgumentException($"Unsupported EquipmentAbility Type in Name(): {nameof(ability)}")
        };
    }

    public static string Description(this EquipmentAbility ability)
    {
        return ability switch
        {
            EquipmentAbility.Vault       => "Grants you the power to jump in the air. Multiple runes stack, allowing for multiple jumps.",
            EquipmentAbility.Sprint      => "Gain the power to dash short distances. Multiple runes stack allowing for multiple dashes.",
            EquipmentAbility.Vampire     => "Killing enemies will drain them of their health. Multiple runes stack for increased life drain.",
            EquipmentAbility.Sky         => "Gain the power of flight. Multiple runes stack for longer flight duration.",
            EquipmentAbility.Siphon      => "Steals mana from slain enemies. Multiple runes stack for increased mana drain.",
            EquipmentAbility.Retaliation => "Returns damage taken from enemies. Multiple runes stack increasing the damage return.",
            EquipmentAbility.Bounty      => "Increase the amount of gold you get from coins. Multiple runes stack for increased gold gain.",
            EquipmentAbility.Haste       => "Increase your base move speed. Multiple runes stack making you even faster.",
            EquipmentAbility.Curse       => "Harder enemies, but greater rewards. Multiple runes stack making enemies even harder.",
            EquipmentAbility.Grace       => "Enemies scale slower, easier but lesser rewards. Multiple runes stack slowing enemy scaling more.",
            EquipmentAbility.Balance     => "Slaying enemies grants both HP and MP. Multiple runes stack for increased hp/mp drain.",
            _                            => throw new ArgumentException($"Unsupported EquipmentAbility Type in Description(): {nameof(ability)}")
        };
    }

    public static string ShortDescription(this EquipmentAbility ability, float amount)
    {
        return ability switch
        {
            EquipmentAbility.Vault                => amount > 1f ? $"Air jump {amount} times." : $"Air jump {amount} time.",
            EquipmentAbility.Sprint               => amount > 1f ? $"Dash up to {amount} times." : $"Dash up to {amount} time.",
            EquipmentAbility.Vampire              => $"Gain back {amount} HP for every kill.",
            EquipmentAbility.Sky                  => amount > 1f ? $"Fly for {amount} seconds." : $"Fly for {amount} second.",
            EquipmentAbility.Siphon               => $"Gain back {amount} MP for every kill.",
            EquipmentAbility.Retaliation          => $"Return {amount}% damage after getting hit.",
            EquipmentAbility.Bounty               => $"Each gold drop is {amount}% more valuable.",
            EquipmentAbility.Haste                => $"Move {amount}% faster.",
            EquipmentAbility.Curse                => $"Enemies start {(int) (amount / 4f * 2.75f)} levels higher.",
            EquipmentAbility.Grace                => amount > 1f ? $"Enemies scale {amount} units slower." : $"Enemies scale {amount} unit slower.",
            EquipmentAbility.Balance              => $"Gain back {amount} HP and MP for every kill.",
            EquipmentAbility.ArchitectFee =>
                $"Earn {100 - RandomizerData.ArchitectFee}% total gold in the castle.",
            EquipmentAbility.NewGamePlusGoldBonus => $"Bounty increased by {amount}%.",
            _                                     => throw new ArgumentException($"Unsupported EquipmentAbility Type in ShortDescription(): {nameof(ability)}")
        };
    }

    public static string Instructions(this EquipmentAbility ability)
    {
        return ability switch
        {
            EquipmentAbility.Vault       => $"Press {InputType.PlayerJump1.Input()} while in air.",
            EquipmentAbility.Sprint      => $"{InputType.PlayerDashLeft.Input()} or {InputType.PlayerDashRight.Input()} to dash.",
            EquipmentAbility.Vampire     => "Kill enemies to regain health.",
            EquipmentAbility.Sky         => $"Hold {InputType.PlayerJump1.Input()} while in air.",
            EquipmentAbility.Siphon      => "Kill enemies to regain mana.",
            EquipmentAbility.Retaliation => "Damage returned to enemies.",
            EquipmentAbility.Bounty      => "Coins give more gold.",
            EquipmentAbility.Haste       => "Move faster.",
            EquipmentAbility.Curse       => "Enemies are harder.",
            EquipmentAbility.Grace       => "Enemies are easier.",
            EquipmentAbility.Balance     => "Kill enemies to regain health and mana.",
            _                            => throw new ArgumentException($"Unsupported EquipmentAbility Type in Instructions(): {nameof(ability)}")
        };
    }

    public static string Icon(this EquipmentAbility ability)
    {
        return ability switch
        {
            EquipmentAbility.Vault       => "EnchantressUI_DoubleJumpIcon_Sprite",
            EquipmentAbility.Sprint      => "EnchantressUI_DashIcon_Sprite",
            EquipmentAbility.Vampire     => "EnchantressUI_VampirismIcon_Sprite",
            EquipmentAbility.Sky         => "EnchantressUI_FlightIcon_Sprite",
            EquipmentAbility.Siphon      => "EnchantressUI_ManaGainIcon_Sprite",
            EquipmentAbility.Retaliation => "EnchantressUI_DamageReturnIcon_Sprite",
            EquipmentAbility.Bounty      => "Icon_Gold_Gain_Up_Sprite",
            EquipmentAbility.Haste       => "EnchantressUI_SpeedUpIcon_Sprite",
            EquipmentAbility.Curse       => "EnchantressUI_CurseIcon_Sprite",
            EquipmentAbility.Grace       => "EnchantressUI_BlessingIcon_Sprite",
            EquipmentAbility.Balance     => "EnchantressUI_BalanceIcon_Sprite",
            _                            => throw new ArgumentException($"Unsupported EquipmentAbility Type in Icon(): {nameof(ability)}")
        };
    }
}
