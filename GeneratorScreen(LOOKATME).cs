/*
 * Programmer: J. C. (Maloka Blacktusk)
 * Version 1.0
 * Description: Specific xpac selection functionality
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoW_Character_Generator
{
    public partial class CharacterGen : Form
    {
        public CharacterGen()
        {
            InitializeComponent();
        }

        struct Expansion
        {
            public int XpacID;
            public int RaceRange;
            public int ClassRange;
            public string XpacName;
            public string Slogan;
            public Expansion(int ID, int races, int classes, string name, string slogan)
            {
                this.XpacID = ID;
                this.RaceRange = races;
                this.ClassRange = classes;
                this.XpacName = name;
                this.Slogan = slogan;
            }
        }
        Expansion[] expansions =
        {
                       //  ID   Races   Classes    Name                       Button Slogan//
            new Expansion( 0,   0,      0,         "",                        "ERROR"), // DEFAULT/ERROR STRUCT
            new Expansion( 1,   8,      9,         "Vanilla",                 "Enter the World of Warcraft..."),
            new Expansion( 2,   10,     9,         "The Burning Crusade",     "You are not prepared!"),
            new Expansion( 3,   10,     10,        "Wrath of the Lich King",  "Frostmourne hungers..."),
            new Expansion( 4,   12,     10,        "Cataclysm",               "All life ends in death!"),
            new Expansion( 5,   14,     11,        "Mists of Pandaria",       "Why do we fight?"),
            new Expansion( 6,   14,     11,        "Warlords of Draenor",     "We will never be slaves!"),
            new Expansion( 7,   14,     12,        "Legion",                  "The Burning Legion has returned..."),
            new Expansion( 8,   24,     12,        "Battle For Azeroth",      "Azeroth needs your help..."),
            new Expansion( 9,   24,     12,        "Shadowlands",             "Delve into the Shadowlands..."),
            new Expansion( 10,  26,     13,        "Dragonflight",            "Awaken the Isles!"),
        };

        Expansion currentExpansion;
        private void ExpansionChecked(object sender, EventArgs e)
        {
            var rdoButton = (RadioButton)sender;
            GenerateButton.Enabled = true;
            OutputCharacter.Text = "";
            // Sets values for selected expansion
            switch (rdoButton.Text)
            {
                #region Blizzard Version
                case "Classic (WotLK)":
                    currentExpansion = expansions[1];
                    break;
                case "Retail (Dragonflight)":
                    currentExpansion = expansions[10];
                    break;
                #endregion
                #region XPAC SPECIFIC
                case "Vanilla":
                    currentExpansion = expansions[1];
                    break;
                case "The Burning Crusade":
                    currentExpansion = expansions[2];
                    break;
                case "Wrath of the Lich King":
                    currentExpansion = expansions[3];
                    break;
                case "Cataclysm":
                    currentExpansion = expansions[4];
                    break;
                case "Mists of Pandaria":
                    currentExpansion = expansions[5];
                    break;
                case "Warlords of Draenor":
                    currentExpansion = expansions[6];
                    break;
                case "Legion":
                    currentExpansion = expansions[7];
                    break;
                case "Battle for Azeroth":
                    currentExpansion = expansions[8];
                    break;
                case "Shadowlands":
                    currentExpansion = expansions[9];
                    break;
                case "Dragonflight":
                    currentExpansion = expansions[10];
                    break;
                #endregion
                case "Surprise Me!":
                    var rnd = new Random();
                    currentExpansion = expansions[rnd.Next(1,expansions.Length)];
                    break;
                default:
                    currentExpansion = expansions[0];
                    GenerateButton.Enabled = false;
                    MessageBox.Show("An error has occured. Please select different expansion (and tell Maloka that something broke!)");
                    break;
            }
            GenerateButton.Text = currentExpansion.Slogan;
        }

        /// <summary>
        /// Randomly selects Race/Class/Spec and displays on text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (currentExpansion.XpacID == 0)
                throw new Exception("Error! Expansion not selected.");
            OutputCharacter.Text = "";
            var character = new NewCharacter(currentExpansion.XpacID, currentExpansion.ClassRange, currentExpansion.RaceRange);
            var newCharacter = character.CharacterSelect();
            if (newCharacter == OutputCharacter.Text) // To help prevent repeats, runs again if output matches last character
                newCharacter = character.CharacterSelect();
            OutputCharacter.Text = newCharacter;
        }

    }

}
