## NOTICE

As of October 11th, 2024, Cellar Door Games has made the source code for RL1 available so this project is being moved to the [Rogue Legacy Randomizer Redux](https://github.com/ThePhar/RogueLegacyRandomizerRedux) repository. 

Any new issues will not be accepted on this repo, as the project will be rewritten on the new repository linked above.
 
 # Rogue Legacy Randomizer

![](https://img.shields.io/github/v/tag/thephar/roguelegacyrandomizer?label=latest&style=flat-square)
![](https://img.shields.io/github/commits-since/thephar/roguelegacyrandomizer/latest/main?color=8df702&style=flat-square)
![](https://img.shields.io/github/license/thephar/roguelegacyrandomizer?style=flat-square)

This project is based on the decompiled and _mostly_ cleaned up source code of *Rogue Legacy* by Cellar Door Games. This project makes quality of life improvements and adds a spin to the core game mechanics by adding additional randomization elements thanks to the [Archipelago](https://archipelago.gg) framework.

## Randomization Features / Changes

* All class upgrades, skill upgrades, blueprints, runes, etc. are shuffled into various location pools that require exploration or spending of gold to obtain.
* All items may be found in the following locations:
    * Fairy and normal chests.
    * Boss chests.
    * Traitor's diaries.
    * Manor upgrades.
    * Mini-bosses and mini-games.
    * Portraits and Jukeboxes.
* The manor skill upgrade screen is split into two sections:
    * Viewing and purchasing of skills and classes you have unlocked.
    * Viewing and purchasing of "manor renovations" which unlock additional items.
* The ability to tweak the difficulty/randomization during initial generation.
    * Starting class, gender, spells, etc.
    * Maximum number of locations to generate.
    * Generated castle size.
    * How skills/classes are acquired when found.
    * If skills/blueprints/runes require purchasing.
    * Number of children per generation.
    * Fountain room door requirement.
    * Gold gain multiplier.
    * Ability to disable Charon taking your gold each run.
    * Toggling of challenge bosses.
    * Start in "New Game Plus" mode or not.

## Multiworld Randomization

You can also randomize items across additional games via the Archipelago framework. You can create a player options file [here](https://archipelago.gg/games/Rogue%20Legacy/player-settings) and share with a host, then from the title screen, connect to the Archipelago room.

### Death Link

You can enable Death Link with other players who have it enabled. If one of you dies, you all die. Sure to make things more exciting.

## Install Instructions (for most users)

In order to install Rogue Legacy Randomizer, you will need to have Rogue Legacy installed on your local machine.

Go to the Releases tab and download the latest version of Rogue Legacy Randomizer and run the installer. It will ask you where your "vanilla" install of Rogue Legacy is located. By default, Rogue Legacy Randomizer installs to `C:\Program Files (x86)\Rogue Legacy Randomizer`.

### Build from Source Instructions

If you prefer to build Rogue Legacy Randomizer from source, you will need to ensure you have the following installed:

* .NET Framework 4.8.1 Developer Pack
* .NET 8.0 Visual Studio SDK
* Visual Studio or Rider
* Rogue Legacy

Clone this repository to a desired directory then follow the below steps:

1. Copy the `Content` directory from your Rogue Legacy directory to this project's root directory (same level as `CustomContent` directory).
2. In Visual Studio or Rider, run "Build".
3. Run the prepare debug powershell script in `util` to copy over all the required libraries and assets to the `bin/Debug` directory.
4. Run `RogueLegacyRandomizer.exe` in `bin/Debug/`.

## License & Copyright

The changes made to the original code is licensed under GPLv3, with the original decompiled source code falling under standard copyright belonging to Cellar Door Games, with permission to be included in this repository. Therefore, all additional copyright notices of Cellar Door Games applies, including not using this source for commercial use and re-releasing it with game files (dlls, assets, etc.).

## Contact Info

You can reach me via email at [zach@alliware.com](mailto://zach@alliware.com) or via my Discord handle: `@thephar`. Alternatively, you can visit the [Archipelago Discord](https://discord.gg/8Z65BR2) server and communicate more on this project in the `#rogue-legacy` channel.
