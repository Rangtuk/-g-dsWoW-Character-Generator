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
            public string Slogan;
            public Expansion(int ID, int races, int classes, string slogan)
            {
                this.XpacID = ID;
                this.RaceRange = races;
                this.ClassRange = classes;
                this.Slogan = slogan;
            }
        }
        /// <summary>
        /// Dictionary implementation courtesy of Te'ja
        /// </summary>
        readonly Dictionary<string, Expansion> XpacDict = new Dictionary<string, Expansion>()
        {
            {"Vanilla", new Expansion( 1, 8, 9, "Enter the World of Warcraft...")},
            {"The Burning Crusade", new Expansion( 2, 10, 9, "You are not prepared!")},
            {"Wrath of the Lich King", new Expansion( 3, 10, 10, "Frostmourne hungers...")},
            {"Cataclysm", new Expansion( 4, 12, 10, "All life ends in death!")},
            {"Mists of Pandaria", new Expansion( 5, 14, 11, "Why do we fight?")},
            {"Warlords of Draenor", new Expansion( 6, 14, 11, "We will never be slaves!")},
            {"Legion", new Expansion( 7, 14, 12, "The Burning Legion has returned...")},
            {"Battle For Azeroth", new Expansion( 8, 24, 12, "Azeroth needs your help...")},
            {"Shadowlands", new Expansion( 9, 24, 12, "Delve into the Shadowlands...")},
            {"Dragonflight", new Expansion( 10, 26, 13, "Awaken the Isles!")},

            {"Classic (WotLK)", new Expansion( 3, 10, 10, "Frostmourne hungers...")},
            {"Retail (Dragonflight)", new Expansion( 10, 26, 13, "Awaken the Isles!")}
        };
        Expansion currentExpansion;
        private void ExpansionChecked(object sender, EventArgs e)
        {
            var rdoButton = (RadioButton)sender;
            GenerateButton.Enabled = true;
            OutputCharacter.Text = "";
            // Sets values for selected expansion or selects random expansion
            if (rdoButton.Text == "Surprise Me!")
                currentExpansion = XpacDict[GetRandomXpac()];
            else
                currentExpansion = XpacDict[rdoButton.Text];
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
        private string GetRandomXpac()
        {
            var keyList = new List<string>(XpacDict.Keys);
            var rnd = new Random();
            return keyList[rnd.Next(0, keyList.Count)];
        }
    }
}
