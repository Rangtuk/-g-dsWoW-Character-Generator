/*
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
        NewCharacter.Expansion currentXpac = new NewCharacter.Expansion();

        /// <summary>
        /// Sets current expansion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpansionChecked(object sender, EventArgs e)
        {
            OutputCharacter.Text = "";
            var rdoButton = (RadioButton)sender;
            currentXpac = character.GetXpac(rdoButton.Text);
            GenerateButton.Text = currentXpac.Slogan;
            GenerateButton.Enabled = true;
        }

        /// <summary>
        /// Randomly selects Race/Class/Spec and displays on text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (currentXpac.XpacID == 0)
                throw new Exception("Error! Expansion not selected.");
            OutputCharacter.Text = "";
            var newCharacter = character.CharacterSelect();
            if (newCharacter == OutputCharacter.Text) // To help prevent repeats, runs again if output matches last generation
                newCharacter = character.CharacterSelect();
            OutputCharacter.Text = newCharacter;
        }

    }
}
