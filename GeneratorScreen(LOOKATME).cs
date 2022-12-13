﻿/*
 * Programmer: J. C. (Maloka Blacktusk)
 * Version 1.0
 * Description: Specific xpac selection functionality
 *****************************************************
 * Version 1.1
 * Description: Encapsulation of NewCharacter code.
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

        NewCharacter character = new NewCharacter();
        NewCharacter.Expansion currentExpansion;

        private void ExpansionChecked(object sender, EventArgs e)
        {
            var rdoButton = (RadioButton)sender;
            GenerateButton.Enabled = true;
            OutputCharacter.Text = "";
            // Sets values for selected expansion or selects random expansion
            if (rdoButton.Text == "Surprise Me!")
                currentExpansion = character.GetRandomXpac();
            else
                currentExpansion = character.GetSpecificXpac(rdoButton.Text);
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
            var newCharacter = character.CharacterSelect();
            if (newCharacter == OutputCharacter.Text) // To help prevent repeats, runs again if output matches last generation
                newCharacter = character.CharacterSelect();
            OutputCharacter.Text = newCharacter;
        }

    }
}
