﻿// 
// RogueLegacyArchipelago - Locations.cs
// Last Modified 2021-12-26
// 
// This project is based on the modified disassembly of Rogue Legacy's engine, with permission to do so by its
// original creators. Therefore, former creators' copyright notice applies to the original disassembly.
// 
// Original Disassembled Source - © 2011-2015, Cellar Door Games Inc.
// Rogue Legacy™ is a trademark or registered trademark of Cellar Door Games Inc. All Rights Reserved.
// 

using System.Collections.Generic;
using System.Linq;

namespace RogueCastle.Archipelago
{
    public static class Locations
    {
        private static readonly Dictionary<string, int> Table = new Dictionary<string, int>
        {
            {"Khindr's Reward Left", 4445000},
            {"Khindr's Reward Right", 4445001},
            {"Alexander's Reward Left", 4445002},
            {"Alexander's Reward Right", 4445003},
            {"Ponce de Leon's Reward Left", 4445004},
            {"Ponce de Leon's Reward Right", 4445005},
            {"Herodotus's Reward Left", 4445006},
            {"Herodotus's Reward Right", 4445007},
            {"Manor Observatory Telescope", 4445008},
            {"Manor Observatory Base", 4445009},
            {"Manor Right High Tower", 4445010},
            {"Manor Right High Upper", 4445011},
            {"Manor Right High Base", 4445012},
            {"Manor Right Big Roof", 4445013},
            {"Manor Right Big Upper", 4445014},
            {"Manor Right Big Base", 4445015},
            {"Manor Right Wing Roof", 4445016},
            {"Manor Right Wing Window", 4445017},
            {"Manor Right Wing Base", 4445018},
            {"Manor Right Extension", 4445019},
            {"Manor Left Far Roof", 4445020},
            {"Manor Left Far Base", 4445021},
            {"Manor Left Big Roof", 4445022},
            {"Manor Left Big Upper 2", 4445023},
            {"Manor Left Big Upper", 4445024},
            {"Manor Left Big Windows", 4445025},
            {"Manor Left Big Base", 4445026},
            {"Manor Left Wing Roof", 4445027},
            {"Manor Left Wing Window", 4445028},
            {"Manor Left Wing Base", 4445029},
            {"Manor Left Extension", 4445030},
            {"Manor Main Roof", 4445031},
            {"Manor Main Base", 4445032},
            {"Manor Front Top Windows", 4445033},
            {"Manor Front Bottom Windows", 4445034},
            {"Manor Ground Road", 4445035},
            {"Manor Left Tree 1", 4445036},
            {"Manor Left Tree 2", 4445037},
            {"Manor Right Tree", 4445038},
            {"Carnival", 4445039},
            {"Cheapskate Elf", 4445040},
            {"Jukebox", 4445041},
            {"Secret Room Chest", 4445042},
            {"Diary 1", 4445043},
            {"Diary 2", 4445044},
            {"Diary 3", 4445045},
            {"Diary 4", 4445046},
            {"Diary 5", 4445047},
            {"Diary 6", 4445048},
            {"Diary 7", 4445049},
            {"Diary 8", 4445050},
            {"Diary 9", 4445051},
            {"Diary 10", 4445052},
            {"Diary 11", 4445053},
            {"Diary 12", 4445054},
            {"Diary 13", 4445055},
            {"Diary 14", 4445056},
            {"Diary 15", 4445057},
            {"Diary 16", 4445058},
            {"Diary 17", 4445059},
            {"Diary 18", 4445060},
            {"Diary 19", 4445061},
            {"Diary 20", 4445062},
            {"Diary 21", 4445063},
            {"Diary 22", 4445064},
            {"Diary 23", 4445065},
            {"Diary 24", 4445066},
            {"Castle Fairy Chest 1", 4445067},
            {"Castle Fairy Chest 2", 4445068},
            {"Castle Fairy Chest 3", 4445069},
            {"Castle Fairy Chest 4", 4445070},
            {"Castle Fairy Chest 5", 4445071},
            {"Castle Fairy Chest 6", 4445072},
            {"Castle Fairy Chest 7", 4445073},
            {"Castle Fairy Chest 8", 4445074},
            {"Castle Fairy Chest 9", 4445075},
            {"Castle Fairy Chest 10", 4445076},
            {"Garden Fairy Chest 1", 4445077},
            {"Garden Fairy Chest 2", 4445078},
            {"Garden Fairy Chest 3", 4445079},
            {"Garden Fairy Chest 4", 4445080},
            {"Garden Fairy Chest 5", 4445081},
            {"Garden Fairy Chest 6", 4445082},
            {"Garden Fairy Chest 7", 4445083},
            {"Garden Fairy Chest 8", 4445084},
            {"Garden Fairy Chest 9", 4445085},
            {"Garden Fairy Chest 10", 4445086},
            {"Tower Fairy Chest 1", 4445087},
            {"Tower Fairy Chest 2", 4445088},
            {"Tower Fairy Chest 3", 4445089},
            {"Tower Fairy Chest 4", 4445090},
            {"Tower Fairy Chest 5", 4445091},
            {"Tower Fairy Chest 6", 4445092},
            {"Tower Fairy Chest 7", 4445093},
            {"Tower Fairy Chest 8", 4445094},
            {"Tower Fairy Chest 9", 4445095},
            {"Tower Fairy Chest 10", 4445096},
            {"Dungeon Fairy Chest 1", 4445097},
            {"Dungeon Fairy Chest 2", 4445098},
            {"Dungeon Fairy Chest 3", 4445099},
            {"Dungeon Fairy Chest 4", 4445100},
            {"Dungeon Fairy Chest 5", 4445101},
            {"Dungeon Fairy Chest 6", 4445102},
            {"Dungeon Fairy Chest 7", 4445103},
            {"Dungeon Fairy Chest 8", 4445104},
            {"Dungeon Fairy Chest 9", 4445105},
            {"Dungeon Fairy Chest 10", 4445106},
            {"Castle Chest 1", 4445107},
            {"Castle Chest 2", 4445108},
            {"Castle Chest 3", 4445109},
            {"Castle Chest 4", 4445110},
            {"Castle Chest 5", 4445111},
            {"Castle Chest 6", 4445112},
            {"Castle Chest 7", 4445113},
            {"Castle Chest 8", 4445114},
            {"Castle Chest 9", 4445115},
            {"Castle Chest 10", 4445116},
            {"Castle Chest 11", 4445117},
            {"Castle Chest 12", 4445118},
            {"Castle Chest 13", 4445119},
            {"Castle Chest 14", 4445120},
            {"Castle Chest 15", 4445121},
            {"Castle Chest 16", 4445122},
            {"Castle Chest 17", 4445123},
            {"Castle Chest 18", 4445124},
            {"Castle Chest 19", 4445125},
            {"Castle Chest 20", 4445126},
            {"Garden Chest 1", 4445127},
            {"Garden Chest 2", 4445128},
            {"Garden Chest 3", 4445129},
            {"Garden Chest 4", 4445130},
            {"Garden Chest 5", 4445131},
            {"Garden Chest 6", 4445132},
            {"Garden Chest 7", 4445133},
            {"Garden Chest 8", 4445134},
            {"Garden Chest 9", 4445135},
            {"Garden Chest 10", 4445136},
            {"Garden Chest 11", 4445137},
            {"Garden Chest 12", 4445138},
            {"Garden Chest 13", 4445139},
            {"Garden Chest 14", 4445140},
            {"Garden Chest 15", 4445141},
            {"Garden Chest 16", 4445142},
            {"Garden Chest 17", 4445143},
            {"Garden Chest 18", 4445144},
            {"Garden Chest 19", 4445145},
            {"Garden Chest 20", 4445146},
            {"Tower Chest 1", 4445147},
            {"Tower Chest 2", 4445148},
            {"Tower Chest 3", 4445149},
            {"Tower Chest 4", 4445150},
            {"Tower Chest 5", 4445151},
            {"Tower Chest 6", 4445152},
            {"Tower Chest 7", 4445153},
            {"Tower Chest 8", 4445154},
            {"Tower Chest 9", 4445155},
            {"Tower Chest 10", 4445156},
            {"Tower Chest 11", 4445157},
            {"Tower Chest 12", 4445158},
            {"Tower Chest 13", 4445159},
            {"Tower Chest 14", 4445160},
            {"Tower Chest 15", 4445161},
            {"Tower Chest 16", 4445162},
            {"Tower Chest 17", 4445163},
            {"Tower Chest 18", 4445164},
            {"Tower Chest 19", 4445165},
            {"Tower Chest 20", 4445166},
            {"Dungeon Chest 1", 4445167},
            {"Dungeon Chest 2", 4445168},
            {"Dungeon Chest 3", 4445169},
            {"Dungeon Chest 4", 4445170},
            {"Dungeon Chest 5", 4445171},
            {"Dungeon Chest 6", 4445172},
            {"Dungeon Chest 7", 4445173},
            {"Dungeon Chest 8", 4445174},
            {"Dungeon Chest 9", 4445175},
            {"Dungeon Chest 10", 4445176},
            {"Dungeon Chest 11", 4445177},
            {"Dungeon Chest 12", 4445178},
            {"Dungeon Chest 13", 4445179},
            {"Dungeon Chest 14", 4445180},
            {"Dungeon Chest 15", 4445181},
            {"Dungeon Chest 16", 4445182},
            {"Dungeon Chest 17", 4445183},
            {"Dungeon Chest 18", 4445184},
            {"Dungeon Chest 19", 4445185},
            {"Dungeon Chest 20", 4445186},
        };

        public static IDictionary<string, int> IdTable
        {
            get { return Table; }
        }

        public static IDictionary<int, string> NameTable
        {
            get { return Table.ToDictionary(kp => kp.Value, kp => kp.Key); }
        }
    }
}