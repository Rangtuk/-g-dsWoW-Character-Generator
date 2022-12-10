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
            this.rdoSL = new System.Windows.Forms.RadioButton();
            this.rdoBFA = new System.Windows.Forms.RadioButton();
            this.rdoLegion = new System.Windows.Forms.RadioButton();
            this.rdoRandomXpac = new System.Windows.Forms.RadioButton();
            this.OutputCharacter = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.rdoVersionClassic = new System.Windows.Forms.RadioButton();
            this.rdoVersionRetail = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoClassic
            // 
            this.rdoClassic.AutoSize = true;
            this.rdoClassic.Location = new System.Drawing.Point(6, 24);
            this.rdoClassic.Name = "rdoClassic";
            this.rdoClassic.Size = new System.Drawing.Size(56, 17);
            this.rdoClassic.TabIndex = 0;
            this.rdoClassic.Text = "Vanilla";
            this.rdoClassic.UseVisualStyleBackColor = true;
            this.rdoClassic.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoTBC
            // 
            this.rdoTBC.AutoSize = true;
            this.rdoTBC.Location = new System.Drawing.Point(6, 47);
            this.rdoTBC.Name = "rdoTBC";
            this.rdoTBC.Size = new System.Drawing.Size(125, 17);
            this.rdoTBC.TabIndex = 1;
            this.rdoTBC.Text = "The Burning Crusade";
            this.rdoTBC.UseVisualStyleBackColor = true;
            this.rdoTBC.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoWrath
            // 
            this.rdoWrath.AutoSize = true;
            this.rdoWrath.Location = new System.Drawing.Point(6, 70);
            this.rdoWrath.Name = "rdoWrath";
            this.rdoWrath.Size = new System.Drawing.Size(131, 17);
            this.rdoWrath.TabIndex = 2;
            this.rdoWrath.Text = "Wrath of the Lich King";
            this.rdoWrath.UseVisualStyleBackColor = true;
            this.rdoWrath.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoCata
            // 
            this.rdoCata.AutoSize = true;
            this.rdoCata.Location = new System.Drawing.Point(6, 93);
            this.rdoCata.Name = "rdoCata";
            this.rdoCata.Size = new System.Drawing.Size(73, 17);
            this.rdoCata.TabIndex = 3;
            this.rdoCata.Text = "Cataclysm";
            this.rdoCata.UseVisualStyleBackColor = true;
            this.rdoCata.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoMoP
            // 
            this.rdoMoP.AutoSize = true;
            this.rdoMoP.Location = new System.Drawing.Point(6, 116);
            this.rdoMoP.Name = "rdoMoP";
            this.rdoMoP.Size = new System.Drawing.Size(106, 17);
            this.rdoMoP.TabIndex = 4;
            this.rdoMoP.Text = "Mists of Pandaria";
            this.rdoMoP.UseVisualStyleBackColor = true;
            this.rdoMoP.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoWoD
            // 
            this.rdoWoD.AutoSize = true;
            this.rdoWoD.Location = new System.Drawing.Point(138, 24);
            this.rdoWoD.Name = "rdoWoD";
            this.rdoWoD.Size = new System.Drawing.Size(120, 17);
            this.rdoWoD.TabIndex = 5;
            this.rdoWoD.Text = "Warlords of Draenor";
            this.rdoWoD.UseVisualStyleBackColor = true;
            this.rdoWoD.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVersionClassic);
            this.groupBox1.Controls.Add(this.rdoWrath);
            this.groupBox1.Controls.Add(this.rdoVersionRetail);
            this.groupBox1.Controls.Add(this.rdoClassic);
            this.groupBox1.Controls.Add(this.rdoDF);
            this.groupBox1.Controls.Add(this.rdoCata);
            this.groupBox1.Controls.Add(this.rdoTBC);
            this.groupBox1.Controls.Add(this.rdoSL);
            this.groupBox1.Controls.Add(this.rdoMoP);
            this.groupBox1.Controls.Add(this.rdoWoD);
            this.groupBox1.Controls.Add(this.rdoBFA);
            this.groupBox1.Controls.Add(this.rdoLegion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 192);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Expansion";
            // 
            // rdoDF
            // 
            this.rdoDF.AutoSize = true;
            this.rdoDF.Location = new System.Drawing.Point(138, 116);
            this.rdoDF.Name = "rdoDF";
            this.rdoDF.Size = new System.Drawing.Size(82, 17);
            this.rdoDF.TabIndex = 9;
            this.rdoDF.Text = "Dragonflight";
            this.rdoDF.UseVisualStyleBackColor = true;
            this.rdoDF.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoSL
            // 
            this.rdoSL.AutoSize = true;
            this.rdoSL.Location = new System.Drawing.Point(138, 93);
            this.rdoSL.Name = "rdoSL";
            this.rdoSL.Size = new System.Drawing.Size(89, 17);
            this.rdoSL.TabIndex = 8;
            this.rdoSL.Text = "Shadowlands";
            this.rdoSL.UseVisualStyleBackColor = true;
            this.rdoSL.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoBFA
            // 
            this.rdoBFA.AutoSize = true;
            this.rdoBFA.Location = new System.Drawing.Point(138, 70);
            this.rdoBFA.Name = "rdoBFA";
            this.rdoBFA.Size = new System.Drawing.Size(109, 17);
            this.rdoBFA.TabIndex = 7;
            this.rdoBFA.Text = "Battle For Azeroth";
            this.rdoBFA.UseVisualStyleBackColor = true;
            this.rdoBFA.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoLegion
            // 
            this.rdoLegion.AutoSize = true;
            this.rdoLegion.Location = new System.Drawing.Point(138, 47);
            this.rdoLegion.Name = "rdoLegion";
            this.rdoLegion.Size = new System.Drawing.Size(57, 17);
            this.rdoLegion.TabIndex = 6;
            this.rdoLegion.Text = "Legion";
            this.rdoLegion.UseVisualStyleBackColor = true;
            this.rdoLegion.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoRandomXpac
            // 
            this.rdoRandomXpac.AutoSize = true;
            this.rdoRandomXpac.Enabled = false;
            this.rdoRandomXpac.Location = new System.Drawing.Point(490, 93);
            this.rdoRandomXpac.Name = "rdoRandomXpac";
            this.rdoRandomXpac.Size = new System.Drawing.Size(138, 17);
            this.rdoRandomXpac.TabIndex = 10;
            this.rdoRandomXpac.Text = "Surprise Me! (BROKEN)";
            this.rdoRandomXpac.UseVisualStyleBackColor = true;
            this.rdoRandomXpac.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // OutputCharacter
            // 
            this.OutputCharacter.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.OutputCharacter.Location = new System.Drawing.Point(12, 464);
            this.OutputCharacter.Multiline = true;
            this.OutputCharacter.Name = "OutputCharacter";
            this.OutputCharacter.ReadOnly = true;
            this.OutputCharacter.Size = new System.Drawing.Size(784, 104);
            this.OutputCharacter.TabIndex = 7;
            this.OutputCharacter.TabStop = false;
            this.OutputCharacter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Enabled = false;
            this.GenerateButton.Location = new System.Drawing.Point(337, 412);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(133, 46);
            this.GenerateButton.TabIndex = 8;
            this.GenerateButton.Text = "Select an Expansion...";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // rdoVersionClassic
            // 
            this.rdoVersionClassic.AutoSize = true;
            this.rdoVersionClassic.Location = new System.Drawing.Point(6, 169);
            this.rdoVersionClassic.Name = "rdoVersionClassic";
            this.rdoVersionClassic.Size = new System.Drawing.Size(100, 17);
            this.rdoVersionClassic.TabIndex = 0;
            this.rdoVersionClassic.Text = "Classic (WotLK)";
            this.rdoVersionClassic.UseVisualStyleBackColor = true;
            this.rdoVersionClassic.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // rdoVersionRetail
            // 
            this.rdoVersionRetail.AutoSize = true;
            this.rdoVersionRetail.Location = new System.Drawing.Point(138, 169);
            this.rdoVersionRetail.Name = "rdoVersionRetail";
            this.rdoVersionRetail.Size = new System.Drawing.Size(118, 17);
            this.rdoVersionRetail.TabIndex = 5;
            this.rdoVersionRetail.Text = "Retail (Dragonflight)";
            this.rdoVersionRetail.UseVisualStyleBackColor = true;
            this.rdoVersionRetail.Click += new System.EventHandler(this.ExpansionChecked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(490, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 50);
            this.textBox1.TabIndex = 12;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Randomly selected TBC, picked gnome priest, dunno why";
            // 
            // CharacterGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(808, 580);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.OutputCharacter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdoRandomXpac);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoW Character Generator - By: Maloka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdoVersionClassic;
        private System.Windows.Forms.RadioButton rdoVersionRetail;
        private System.Windows.Forms.TextBox textBox1;
    }
}

