﻿namespace AnimauxMenuContextuel
{
    partial class AnimauxMenuContextuelForm
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
            this.components = new System.ComponentModel.Container();
            this.animauxListBox = new System.Windows.Forms.ListBox();
            this.nomAnimalLabel = new System.Windows.Forms.Label();
            this.nomAnimalTextBox = new System.Windows.Forms.TextBox();
            this.retrouverButton = new System.Windows.Forms.Button();
            this.InsererButton = new System.Windows.Forms.Button();
            this.animauxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animauxContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // animauxListBox
            // 
            this.animauxListBox.ContextMenuStrip = this.animauxContextMenuStrip;
            this.animauxListBox.FormattingEnabled = true;
            this.animauxListBox.ItemHeight = 16;
            this.animauxListBox.Items.AddRange(new object[] {
            "Baleine",
            "Chat",
            "Chauve-Souris",
            "Chien",
            "Cougard"});
            this.animauxListBox.Location = new System.Drawing.Point(34, 39);
            this.animauxListBox.Name = "animauxListBox";
            this.animauxListBox.Size = new System.Drawing.Size(135, 100);
            this.animauxListBox.TabIndex = 0;
            // 
            // nomAnimalLabel
            // 
            this.nomAnimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomAnimalLabel.Location = new System.Drawing.Point(186, 36);
            this.nomAnimalLabel.Name = "nomAnimalLabel";
            this.nomAnimalLabel.Size = new System.Drawing.Size(190, 24);
            this.nomAnimalLabel.TabIndex = 1;
            this.nomAnimalLabel.Text = "Nom de l\'animal:";
            // 
            // nomAnimalTextBox
            // 
            this.nomAnimalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomAnimalTextBox.Location = new System.Drawing.Point(189, 63);
            this.nomAnimalTextBox.Multiline = true;
            this.nomAnimalTextBox.Name = "nomAnimalTextBox";
            this.nomAnimalTextBox.Size = new System.Drawing.Size(258, 24);
            this.nomAnimalTextBox.TabIndex = 2;
            // 
            // retrouverButton
            // 
            this.retrouverButton.Location = new System.Drawing.Point(189, 102);
            this.retrouverButton.Name = "retrouverButton";
            this.retrouverButton.Size = new System.Drawing.Size(126, 34);
            this.retrouverButton.TabIndex = 3;
            this.retrouverButton.Text = "Retrouver";
            this.retrouverButton.UseVisualStyleBackColor = true;
            this.retrouverButton.Click += new System.EventHandler(this.retrouverButton_Click);
            // 
            // InsererButton
            // 
            this.InsererButton.Location = new System.Drawing.Point(321, 102);
            this.InsererButton.Name = "InsererButton";
            this.InsererButton.Size = new System.Drawing.Size(126, 34);
            this.InsererButton.TabIndex = 4;
            this.InsererButton.Text = "Inserer";
            this.InsererButton.UseVisualStyleBackColor = true;
            this.InsererButton.Click += new System.EventHandler(this.InsererButton_Click);
            // 
            // animauxContextMenuStrip
            // 
            this.animauxContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.animauxContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.animauxContextMenuStrip.Name = "animauxContextMenuStrip";
            this.animauxContextMenuStrip.Size = new System.Drawing.Size(146, 28);
            this.animauxContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.animauxContextMenuStrip_Opening);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.supprimerToolStripMenuItem.Text = "supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // AnimauxMenuContextuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 167);
            this.Controls.Add(this.InsererButton);
            this.Controls.Add(this.retrouverButton);
            this.Controls.Add(this.nomAnimalTextBox);
            this.Controls.Add(this.nomAnimalLabel);
            this.Controls.Add(this.animauxListBox);
            this.Name = "AnimauxMenuContextuelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animaux et menu contextuel";
            this.Load += new System.EventHandler(this.AnimauxMenuContextuelForm_Load);
            this.animauxContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox animauxListBox;
        private System.Windows.Forms.Label nomAnimalLabel;
        private System.Windows.Forms.TextBox nomAnimalTextBox;
        private System.Windows.Forms.Button retrouverButton;
        private System.Windows.Forms.Button InsererButton;
        private System.Windows.Forms.ContextMenuStrip animauxContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}

