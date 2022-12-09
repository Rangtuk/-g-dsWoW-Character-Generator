namespace WoW_Character_Generator
{
    partial class CharacterGen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdoClassic = new System.Windows.Forms.RadioButton();
            this.rdoTBC = new System.Windows.Forms.RadioButton();
            this.rdoWrath = new System.Windows.Forms.RadioButton();
            this.rdoCata = new System.Windows.Forms.RadioButton();
            this.rdoMoP = new System.Windows.Forms.RadioButton();
            this.rdoWoD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDF = new System.Windows.Forms.RadioButton();
            this.rdoRandomXpac = new System.Windows.Forms.RadioButton();
            this.rdoSL = new System.Windows.Forms.RadioButton();
            this.rdoBFA = new System.Windows.Forms.RadioButton();
            this.rdoLegion = new System.Windows.Forms.RadioButton();
            this.OutputCharacter = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.grpGenericVersion = new System.Windows.Forms.GroupBox();
            this.rdoVersionClassic = new System.Windows.Forms.RadioButton();
            this.rdoVersionRetail = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpGenericVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoClassic
            // 
            this.rdoClassic.AutoSize = true;
            this.rdoClassic.Location = new System.Drawing.Point(8, 30);
            this.rdoClassic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoClassic.Name = "rdoClassic";
            this.rdoClassic.Size = new System.Drawing.Size(69, 20);
            this.rdoClassic.TabIndex = 0;
            this.rdoClassic.Text = "Vanilla";
            this.rdoClassic.UseVisualStyleBackColor = true;
            this.rdoClassic.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoTBC
            // 
            this.rdoTBC.AutoSize = true;
            this.rdoTBC.Location = new System.Drawing.Point(8, 58);
            this.rdoTBC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoTBC.Name = "rdoTBC";
            this.rdoTBC.Size = new System.Drawing.Size(154, 20);
            this.rdoTBC.TabIndex = 1;
            this.rdoTBC.Text = "The Burning Crusade";
            this.rdoTBC.UseVisualStyleBackColor = true;
            this.rdoTBC.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoWrath
            // 
            this.rdoWrath.AutoSize = true;
            this.rdoWrath.Location = new System.Drawing.Point(8, 86);
            this.rdoWrath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoWrath.Name = "rdoWrath";
            this.rdoWrath.Size = new System.Drawing.Size(154, 20);
            this.rdoWrath.TabIndex = 2;
            this.rdoWrath.Text = "Wrath of the Lich King";
            this.rdoWrath.UseVisualStyleBackColor = true;
            this.rdoWrath.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoCata
            // 
            this.rdoCata.AutoSize = true;
            this.rdoCata.Location = new System.Drawing.Point(8, 114);
            this.rdoCata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoCata.Name = "rdoCata";
            this.rdoCata.Size = new System.Drawing.Size(91, 20);
            this.rdoCata.TabIndex = 3;
            this.rdoCata.Text = "Cataclysm";
            this.rdoCata.UseVisualStyleBackColor = true;
            this.rdoCata.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoMoP
            // 
            this.rdoMoP.AutoSize = true;
            this.rdoMoP.Location = new System.Drawing.Point(8, 143);
            this.rdoMoP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoMoP.Name = "rdoMoP";
            this.rdoMoP.Size = new System.Drawing.Size(131, 20);
            this.rdoMoP.TabIndex = 4;
            this.rdoMoP.Text = "Mists of Pandaria";
            this.rdoMoP.UseVisualStyleBackColor = true;
            this.rdoMoP.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoWoD
            // 
            this.rdoWoD.AutoSize = true;
            this.rdoWoD.Location = new System.Drawing.Point(184, 30);
            this.rdoWoD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoWoD.Name = "rdoWoD";
            this.rdoWoD.Size = new System.Drawing.Size(149, 20);
            this.rdoWoD.TabIndex = 5;
            this.rdoWoD.Text = "Warlords of Draenor";
            this.rdoWoD.UseVisualStyleBackColor = true;
            this.rdoWoD.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoWrath);
            this.groupBox1.Controls.Add(this.rdoClassic);
            this.groupBox1.Controls.Add(this.rdoDF);
            this.groupBox1.Controls.Add(this.rdoCata);
            this.groupBox1.Controls.Add(this.rdoTBC);
            this.groupBox1.Controls.Add(this.rdoSL);
            this.groupBox1.Controls.Add(this.rdoMoP);
            this.groupBox1.Controls.Add(this.rdoWoD);
            this.groupBox1.Controls.Add(this.rdoBFA);
            this.groupBox1.Controls.Add(this.rdoLegion);
            this.groupBox1.Location = new System.Drawing.Point(16, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(351, 236);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Expansion";
            // 
            // rdoDF
            // 
            this.rdoDF.AutoSize = true;
            this.rdoDF.Location = new System.Drawing.Point(184, 143);
            this.rdoDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoDF.Name = "rdoDF";
            this.rdoDF.Size = new System.Drawing.Size(100, 20);
            this.rdoDF.TabIndex = 9;
            this.rdoDF.Text = "Dragonflight";
            this.rdoDF.UseVisualStyleBackColor = true;
            this.rdoDF.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoRandomXpac
            // 
            this.rdoRandomXpac.AutoSize = true;
            this.rdoRandomXpac.Enabled = false;
            this.rdoRandomXpac.Location = new System.Drawing.Point(654, 115);
            this.rdoRandomXpac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoRandomXpac.Name = "rdoRandomXpac";
            this.rdoRandomXpac.Size = new System.Drawing.Size(170, 20);
            this.rdoRandomXpac.TabIndex = 10;
            this.rdoRandomXpac.Text = "Surprise Me! (BROKEN)";
            this.rdoRandomXpac.UseVisualStyleBackColor = true;
            this.rdoRandomXpac.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoSL
            // 
            this.rdoSL.AutoSize = true;
            this.rdoSL.Location = new System.Drawing.Point(184, 114);
            this.rdoSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoSL.Name = "rdoSL";
            this.rdoSL.Size = new System.Drawing.Size(110, 20);
            this.rdoSL.TabIndex = 8;
            this.rdoSL.Text = "Shadowlands";
            this.rdoSL.UseVisualStyleBackColor = true;
            this.rdoSL.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoBFA
            // 
            this.rdoBFA.AutoSize = true;
            this.rdoBFA.Location = new System.Drawing.Point(184, 86);
            this.rdoBFA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBFA.Name = "rdoBFA";
            this.rdoBFA.Size = new System.Drawing.Size(133, 20);
            this.rdoBFA.TabIndex = 7;
            this.rdoBFA.Text = "Battle For Azeroth";
            this.rdoBFA.UseVisualStyleBackColor = true;
            this.rdoBFA.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoLegion
            // 
            this.rdoLegion.AutoSize = true;
            this.rdoLegion.Location = new System.Drawing.Point(184, 58);
            this.rdoLegion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoLegion.Name = "rdoLegion";
            this.rdoLegion.Size = new System.Drawing.Size(69, 20);
            this.rdoLegion.TabIndex = 6;
            this.rdoLegion.Text = "Legion";
            this.rdoLegion.UseVisualStyleBackColor = true;
            this.rdoLegion.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // OutputCharacter
            // 
            this.OutputCharacter.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.OutputCharacter.Location = new System.Drawing.Point(16, 571);
            this.OutputCharacter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputCharacter.Multiline = true;
            this.OutputCharacter.Name = "OutputCharacter";
            this.OutputCharacter.ReadOnly = true;
            this.OutputCharacter.Size = new System.Drawing.Size(1044, 127);
            this.OutputCharacter.TabIndex = 7;
            this.OutputCharacter.TabStop = false;
            this.OutputCharacter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Enabled = false;
            this.GenerateButton.Location = new System.Drawing.Point(449, 507);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(177, 57);
            this.GenerateButton.TabIndex = 8;
            this.GenerateButton.Text = "Select an Expansion...";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // grpGenericVersion
            // 
            this.grpGenericVersion.Controls.Add(this.rdoVersionClassic);
            this.grpGenericVersion.Controls.Add(this.rdoVersionRetail);
            this.grpGenericVersion.Location = new System.Drawing.Point(16, 15);
            this.grpGenericVersion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGenericVersion.Name = "grpGenericVersion";
            this.grpGenericVersion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGenericVersion.Size = new System.Drawing.Size(348, 62);
            this.grpGenericVersion.TabIndex = 11;
            this.grpGenericVersion.TabStop = false;
            this.grpGenericVersion.Text = "Select Blizzard Version";
            // 
            // rdoVersionClassic
            // 
            this.rdoVersionClassic.AutoSize = true;
            this.rdoVersionClassic.Location = new System.Drawing.Point(17, 30);
            this.rdoVersionClassic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoVersionClassic.Name = "rdoVersionClassic";
            this.rdoVersionClassic.Size = new System.Drawing.Size(122, 20);
            this.rdoVersionClassic.TabIndex = 0;
            this.rdoVersionClassic.Text = "Classic (WotLK)";
            this.rdoVersionClassic.UseVisualStyleBackColor = true;
            this.rdoVersionClassic.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoVersionRetail
            // 
            this.rdoVersionRetail.AutoSize = true;
            this.rdoVersionRetail.Location = new System.Drawing.Point(175, 30);
            this.rdoVersionRetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoVersionRetail.Name = "rdoVersionRetail";
            this.rdoVersionRetail.Size = new System.Drawing.Size(146, 20);
            this.rdoVersionRetail.TabIndex = 5;
            this.rdoVersionRetail.Text = "Retail (Dragonflight)";
            this.rdoVersionRetail.UseVisualStyleBackColor = true;
            this.rdoVersionRetail.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(654, 142);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(184, 61);
            this.textBox1.TabIndex = 12;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Randomly selected TBC, picked gnome priest, dunno why";
            // 
            // CharacterGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1077, 714);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpGenericVersion);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.OutputCharacter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdoRandomXpac);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoW Character Generator - By: Maloka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGenericVersion.ResumeLayout(false);
            this.grpGenericVersion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoClassic;
        private System.Windows.Forms.RadioButton rdoTBC;
        private System.Windows.Forms.RadioButton rdoWrath;
        private System.Windows.Forms.RadioButton rdoCata;
        private System.Windows.Forms.RadioButton rdoMoP;
        private System.Windows.Forms.RadioButton rdoWoD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoRandomXpac;
        private System.Windows.Forms.RadioButton rdoDF;
        private System.Windows.Forms.RadioButton rdoSL;
        private System.Windows.Forms.RadioButton rdoBFA;
        private System.Windows.Forms.RadioButton rdoLegion;
        private System.Windows.Forms.TextBox OutputCharacter;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.GroupBox grpGenericVersion;
        private System.Windows.Forms.RadioButton rdoVersionClassic;
        private System.Windows.Forms.RadioButton rdoVersionRetail;
        private System.Windows.Forms.TextBox textBox1;
    }
}

