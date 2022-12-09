using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoW_Character_Generator
{
    public class NewCharacter
    {
        // Array of all available races
        private readonly string[] Races = { "Human", "Orc", "Dwarf", "Undead", "Gnome", "Troll", "Night Elf", "Tauren", "Draenei", "Blood Elf", "Worgen", "Goblin", "Pandaren (Alliance)", "Pandaren (Horde)", "Void Elf", "Nightborne", "Lightforged Draenei", "Highmountain Tauren", "Dark Iron Dwarf", "Mag'har Orc", "Kul Tiran", "Zandalari Troll", "Mechagnome", "Vulpera", "Dracthyr (Alliance)", "Dracthyr (Horde)" };
        // Array of actual class names and specs
        private readonly string[][] Classes = new string[][]
        {
                new string[] {"Arms", "Fury", "Protection", "Warrior"},                // [0]
                new string[] {"Beast Mastery", "Marksmanship", "Survival", "Hunter"},  // [1]
                new string[] {"Assassination", "Combat/Outlaw", "Subtlety", "Rogue"},  // [2]
                new string[] {"Arcane", "Fire", "Frost", "Mage"},                      // [3]
                new string[] {"Discipline", "Holy", "Shadow", "Priest"},               // [4]
                new string[] {"Balance", "Guardian", "Feral", "Restoration", "Druid"}, // [5]
                new string[] {"Affliction", "Demonology", "Destruction", "Warlock"},   // [6]
                new string[] {"Holy", "Protection", "Retribution", "Paladin"},         // [7]
                new string[] {"Elemental", "Enhancement", "Restoration", "Shaman"},    // [8]
                new string[] {"Blood", "Frost", "Unholy", "Death Knight"},             // [9]
                new string[] {"Mistweaver", "Brewmaster", "Windwalker", "Monk"},       // [10]
                new string[] {"Havoc", "Vengeance", "Demon Hunter"},                   // [11]
                new string[] {"Devastation", "Preservation", "Evoker"},                // [12]
        };
        // Assigned IDs to classes array above
        private readonly string[] ClassIDs = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c" };
        
        private readonly int Xpac;
        private readonly int ClassRange;
        private readonly int RaceRange;
        
        public NewCharacter(int xpac, int classRange, int raceRange)
        {
            this.Xpac = xpac;
            this.ClassRange = classRange;
            this.RaceRange = raceRange;
        }

        /// <summary>
        /// Returns selected Race/Class combo
        /// </summary>
        /// <param name="xpac"></param>
        /// <param name="race"></param>
        public string CharacterSelect()
        {
            var SelectedRace = RaceSelect();
            var SelectedClass = ClassSelect(SelectedRace);
            var SelectedCharacter = String.Format("Race: {1}{0}Class: {2}", Environment.NewLine, SelectedRace, SelectedClass);
            return SelectedCharacter;
        }

        /// <summary>
        /// Selects random race from predetermined range
        /// </summary>
        /// <param name="xpac"></param>
        /// <param name="raceRange"></param>
        private string RaceSelect()
        {
            var randRace = new Random();
            return Races[randRace.Next(0, RaceRange)]; // Max 26 (excluded)           
        }

        /// <summary>
        /// Returns random valid class/spec based on selected race and expansion
        /// </summary>
        /// <param name="race"></param>
        /// <returns></returns>
        private string ClassSelect(string race)
        {           
            var randClass = new Random();
            var validClasses = "";
            var randomClassID = "";
            var selectedBaseClass = "";
            var selectedSpec = "";

            /// Gets list of valid classes for xpac + race
            switch (Xpac)
            {
                case 1:  // Vanilla
                    switch (race)
                    {
                        //Warr 0, Hun 1, Rog 2, Mag 3, Pri 4, Drui 5, Warl 6, Pal 7, Sha 8
                        case "Human":
                            validClasses = "023467";
                            break;
                        case "Orc":
                            validClasses = "01268";
                            break;
                        case "Dwarf":
                            validClasses = "01247";
                            break;
                        case "Undead":
                            validClasses = "02346";
                            break;
                        case "Night Elf":
                            validClasses = "01245";
                            break;
                        case "Tauren":
                            validClasses = "0158";
                            break;
                        case "Gnome":
                            validClasses = "0236";
                            break;
                        case "Troll":
                            validClasses = "012348";
                            break;
                    }
                    break;
                case 2:  // TBC
                    switch (race)
                    {
                        //Warr 0, Hun 1, Rog 2, Mag 3, Pri 4, Drui 5, Warl 6, Pal 7, Sha 8
                        case "Human":
                            validClasses = "023467";
                            break;
                        case "Orc":
                            validClasses = "01268";
                            break;
                        case "Dwarf":
                            validClasses = "01247";
                            break;
                        case "Undead":
                            validClasses = "02346";
                            break;
                        case "Night Elf":
                            validClasses = "01245";
                            break;
                        case "Tauren":
                            validClasses = "0158";
                            break;
                        case "Gnome":
                            validClasses = "0236";
                            break;
                        case "Troll":
                            validClasses = "012348";
                            break;
                        case "Draenei":
                            validClasses = "013478";
                            break;
                        case "Blood Elf":
                            validClasses = "123467";
                            break;
                    }
                    break;
                case 3:  // Wrath                   
                    switch (race)
                    {
                        //Warr 0, Hun 1, Rog 2, Mag 3, Pri 4, Drui 5, Warl 6, Pal 7, Sha 8, DK 9
                        case "Human":
                            validClasses = "9023467";
                            break;
                        case "Orc":
                            validClasses = "901268";
                            break;
                        case "Dwarf":
                            validClasses = "901247";
                            break;
                        case "Undead":
                            validClasses = "902346";
                            break;
                        case "Night Elf":
                            validClasses = "901245";
                            break;
                        case "Tauren":
                            validClasses = "90158";
                            break;
                        case "Gnome":
                            validClasses = "90236";
                            break;
                        case "Troll":
                            validClasses = "9012348";
                            break;
                        case "Draenei":
                            validClasses = "9013478";
                            break;
                        case "Blood Elf":
                            validClasses = "9123467";
                            break;
                    }
                    break;
                case 4:  // Cata
                    switch (race)
                    {
                        //Warr 0, Hun 1, Rog 2, Mag 3, Pri 4, Drui 5, Warl 6, Pal 7, Sha 8, DK 9
                        case "Human":
                            validClasses = "90123467";
                            break;
                        case "Orc":
                            validClasses = "9012368";
                            break;
                        case "Dwarf":
                            validClasses = "90123478";
                            break;
                        case "Undead":
                            validClasses = "9012346";
                            break;
                        case "Night Elf":
                            validClasses = "9012345";
                            break;
                        case "Tauren":
                            validClasses = "9014578";
                            break;
                        case "Gnome":
                            validClasses = "902346";
                            break;
                        case "Troll":
                            validClasses = "90123458";
                            break;
                        case "Draenei":
                            validClasses = "9013478";
                            break;
                        case "Blood Elf":
                            validClasses = "90123467";
                            break;
                        case "Worgen":
                            validClasses = "90123456";
                            break;
                        case "Goblin":
                            validClasses = "90123468";
                            break;
                    }
                    break;
                case 5:  // MoP
                    switch (race)
                    {
                        //Warr 0, Hun 1, Rog 2, Mag 3, Pri 4, Drui 5, Warl 6, Pal 7, Sha 8, DK 9, Mon a
                        case "Human":
                            validClasses = "a90123467";
                            break;
                        case "Orc":
                            validClasses = "a9012368";
                            break;
                        case "Dwarf":
                            validClasses = "a90123478";
                            break;
                        case "Undead":
                            validClasses = "a9012346";
                            break;
                        case "Night Elf":
                            validClasses = "a9012345";
                            break;
                        case "Tauren":
                            validClasses = "a9014578";
                            break;
                        case "Gnome":
                            validClasses = "a902346";
                            break;
                        case "Troll":
                            validClasses = "a90123458";
                            break;
                        case "Draenei":
                            validClasses = "a9013478";
                            break;
                        case "Blood Elf":
                            validClasses = "a90123467";
                            break;
                        case "Worgen":
                            validClasses = "90123456";
                            break;
                        case "Goblin":
                            validClasses = "90123468";
                            break;
                        case "Pandaren (Alliance)":
                            validClasses = "a012348";
                            break;
                        case "Pandaren (Horde)":
                            validClasses = "a012348";
                            break;
                    }
                    break;
                case 6:  // WoD
                    switch (race)
                    {
                        //Warr 0, Hun 1, Rog 2, Mag 3, Pri 4, Drui 5, Warl 6, Pal 7, Sha 8, DK 9, Mon a
                        case "Human":
                            validClasses = "a90123467";
                            break;
                        case "Orc":
                            validClasses = "a9012368";
                            break;
                        case "Dwarf":
                            validClasses = "a90123478";
                            break;
                        case "Undead":
                            validClasses = "a9012346";
                            break;
                        case "Night Elf":
                            validClasses = "a9012345";
                            break;
                        case "Tauren":
                            validClasses = "a9014578";
                            break;
                        case "Gnome":
                            validClasses = "a902346";
                            break;
                        case "Troll":
                            validClasses = "a90123458";
                            break;
                        case "Draenei":
                            validClasses = "a9013478";
                            break;
                        case "Blood Elf":
                            validClasses = "a90123467";
                            break;
                        case "Worgen":
                            validClasses = "90123456";
                            break;
                        case "Goblin":
                            validClasses = "90123468";
                            break;
                        case "Pandaren (Alliance)":
                            validClasses = "a012348";
                            break;
                        case "Pandaren (Horde)":
                            validClasses = "a012348";
                            break;
                    }
                    break;
                case 7:  // Legion
                    switch (race)
                    {
                        //Warr 0, Hun 1, Rog 2, Mag 3, Pri 4, Drui 5, Warl 6, Pal 7, Sha 8, DK 9, Mon a, DH b
                        case "Human":
                            validClasses = "a90123467";
                            break;
                        case "Orc":
                            validClasses = "a9012368";
                            break;
                        case "Dwarf":
                            validClasses = "a90123478";
                            break;
                        case "Undead":
                            validClasses = "a9012346";
                            break;
                        case "Night Elf":
                            validClasses = "ba9012345";
                            break;
                        case "Tauren":
                            validClasses = "a9014578";
                            break;
                        case "Gnome":
                            validClasses = "a9012346";
                            break;
                        case "Troll":
                            validClasses = "a90123458";
                            break;
                        case "Draenei":
                            validClasses = "a9013478";
                            break;
                        case "Blood Elf":
                            validClasses = "ba90123467";
                            break;
                        case "Worgen":
                            validClasses = "90123456";
                            break;
                        case "Goblin":
                            validClasses = "90123468";
                            break;
                        case "Pandaren (Alliance)":
                            validClasses = "a012348";
                            break;
                        case "Pandaren (Horde)":
                            validClasses = "a012348";
                            break;
                    }
                    break;
                case 8:  // BFA
                    switch (race)
                    {
                        //Warr 0, Hun 1, Rog 2, Mag 3, Pri 4, Drui 5, Warl 6, Pal 7, Sha 8, DK 9, Mon a, DH b
                        #region Old Races
                        case "Human":
                            validClasses = "a90123467";
                            break;
                        case "Orc":
                            validClasses = "a9012368";
                            break;
                        case "Dwarf":
                            validClasses = "a90123478";
                            break;
                        case "Undead":
                            validClasses = "a9012346";
                            break;
                        case "Night Elf":
                            validClasses = "ba9012345";
                            break;
                        case "Tauren":
                            validClasses = "a9014578";
                            break;
                        case "Gnome":
                            validClasses = "a9012346";
                            break;
                        case "Troll":
                            validClasses = "a90123458";
                            break;
                        case "Draenei":
                            validClasses = "a9013478";
                            break;
                        case "Blood Elf":
                            validClasses = "ba90123467";
                            break;
                        case "Worgen":
                            validClasses = "90123456";
                            break;
                        case "Goblin":
                            validClasses = "90123468";
                            break;
                        case "Pandaren (Alliance)":
                            validClasses = "a012348";
                            break;
                        case "Pandaren (Horde)":
                            validClasses = "a012348";
                            break;
                        #endregion
                        #region Allied
                        case "Void Elf":
                            validClasses = "012346a";
                            break;
                        case "Nightborne":
                            validClasses = "012346a";
                            break;
                        case "Lightforged Draenei":
                            validClasses = "01347";
                            break;
                        case "Highmountain Tauren":
                            validClasses = "0158a";
                            break;
                        case "Dark Iron Dwarf":
                            validClasses = "01234678a";
                            break;
                        case "Mag'har Orc":
                            validClasses = "012348a";
                            break;
                        case "Kul Tiran":
                            validClasses = "51a4280";
                            break;
                        case "Zandalari Troll":
                            validClasses = "012345678a";
                            break;
                        case "Mechagnome":
                            validClasses = "012346a";
                            break;
                        case "Vulpera":
                            validClasses = "01236";
                            break;
                            #endregion
                    }
                    break;
                case 9:  // SL
                    switch (race)
                    {
                        //Warr 0, Hun 1, Rog 2, Mag 3, Pri 4, Drui 5, Warl 6, Pal 7, Sha 8, DK 9, Mon a, DH b
                        #region Old Races
                        case "Human":
                            validClasses = "a90123467";
                            break;
                        case "Orc":
                            validClasses = "a9012368";
                            break;
                        case "Dwarf":
                            validClasses = "a90123478";
                            break;
                        case "Undead":
                            validClasses = "a9012346";
                            break;
                        case "Night Elf":
                            validClasses = "ba9012345";
                            break;
                        case "Tauren":
                            validClasses = "a9014578";
                            break;
                        case "Gnome":
                            validClasses = "a9012346";
                            break;
                        case "Troll":
                            validClasses = "a90123458";
                            break;
                        case "Draenei":
                            validClasses = "a9013478";
                            break;
                        case "Blood Elf":
                            validClasses = "ba90123467";
                            break;
                        case "Worgen":
                            validClasses = "90123456";
                            break;
                        case "Goblin":
                            validClasses = "90123468";
                            break;
                        case "Pandaren (Alliance)":
                            validClasses = "a012348";
                            break;
                        case "Pandaren (Horde)":
                            validClasses = "a012348";
                            break;
                        #endregion
                        #region Allied
                        case "Void Elf":
                            validClasses = "012346a9";
                            break;
                        case "Nightborne":
                            validClasses = "012346a9";
                            break;
                        case "Lightforged Draenei":
                            validClasses = "013479";
                            break;
                        case "Highmountain Tauren":
                            validClasses = "0158a9";
                            break;
                        case "Dark Iron Dwarf":
                            validClasses = "01234678a9";
                            break;
                        case "Mag'har Orc":
                            validClasses = "012348a9";
                            break;
                        case "Kul Tiran":
                            validClasses = "51a42809";
                            break;
                        case "Zandalari Troll":
                            validClasses = "012345678a9";
                            break;
                        case "Mechagnome":
                            validClasses = "012346a9";
                            break;
                        case "Vulpera":
                            validClasses = "012369";
                            break;
                            #endregion
                    }
                    break;
                case 10: // DF
                    switch (race)
                    {
                        //Warr 0, Hun 1, Rog 2, Mag 3, Pri 4, Drui 5, Warl 6, Pal 7, Sha 8, DK 9, Mon a, DH b, Evo c
                        #region Old Races
                        case "Human":
                            validClasses = "a90123467";
                            break;
                        case "Orc":
                            validClasses = "a90123468";
                            break;
                        case "Dwarf":
                            validClasses = "a90123478";
                            break;
                        case "Undead":
                            validClasses = "a9012346";
                            break;
                        case "Night Elf":
                            validClasses = "ba9012345";
                            break;
                        case "Tauren":
                            validClasses = "a901234578";
                            break;
                        case "Gnome":
                            validClasses = "a9012346";
                            break;
                        case "Troll":
                            validClasses = "a90123458";
                            break;
                        case "Draenei":
                            validClasses = "a90123478";
                            break;
                        case "Blood Elf":
                            validClasses = "ba90123467";
                            break;
                        case "Worgen":
                            validClasses = "90123456";
                            break;
                        case "Goblin":
                            validClasses = "90123468";
                            break;
                        case "Pandaren (Alliance)":
                            validClasses = "a012348";
                            break;
                        case "Pandaren (Horde)":
                            validClasses = "a012348";
                            break;
                        case "Dracthyr (Alliance)":
                            validClasses = "c";
                            break;
                        case "Dracthyr (Horde)":
                            validClasses = "c";
                            break;
                        #endregion
                        #region Allied
                        case "Void Elf":
                            validClasses = "012346a9";
                            break;
                        case "Nightborne":
                            validClasses = "012346a9";
                            break;
                        case "Lightforged Draenei":
                            validClasses = "0123479";
                            break;
                        case "Highmountain Tauren":
                            validClasses = "0123458a9";
                            break;
                        case "Dark Iron Dwarf":
                            validClasses = "01234678a9";
                            break;
                        case "Mag'har Orc":
                            validClasses = "012348a9";
                            break;
                        case "Kul Tiran":
                            validClasses = "0123458a9";
                            break;
                        case "Zandalari Troll":
                            validClasses = "012345678a9";
                            break;
                        case "Mechagnome":
                            validClasses = "012346a9";
                            break;
                        case "Vulpera":
                            validClasses = "012346a9";
                            break;
                            #endregion
                    }
                    break;
                default:
                    break;
            }

            /// Loops through random classes until finding one that is valid for selected race
            while (randomClassID == "")
            {
                if (race.Contains("Dracthyr") && Xpac == 10) // Cheat so loop isn't running for 5000 years to find one singular class
                {
                    var DFDracthyrSpec = new Random();
                    selectedBaseClass = "Evoker";
                    selectedSpec = Classes[12][DFDracthyrSpec.Next(0, 1)];
                    break;
                }
                randomClassID = ClassIDs[randClass.Next(0,ClassRange)];
                if (validClasses.Contains(randomClassID)) // if ("01234abc".Contains("a"))
                {
                    var randSpec = new Random();
                    int selectedRow = Array.IndexOf(ClassIDs, randomClassID);
                    selectedBaseClass = Classes[selectedRow][Classes[selectedRow].Length - 1];
                    selectedSpec = Classes[selectedRow][randSpec.Next(0, Classes[selectedRow].Length - 1)]; //selects random spec from selected class
                    break; // Breaks loop once valid class is found
                }
                randomClassID = "";
            }
            return String.Format("{0} {1}", selectedSpec, selectedBaseClass);
        }
    }
}
