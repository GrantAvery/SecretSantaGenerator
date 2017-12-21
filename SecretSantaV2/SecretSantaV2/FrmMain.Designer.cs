//-----------------------------------------------------------------------
// <copyright file="Form1.Designer.cs" company="GrantAvery">
//     Copyright (c) Grant Avery. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SecretSantaV2
{
    /// <summary>
    /// The designer class of Form1.
    /// </summary>
    public partial class SecretSantaGenerator
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txbNumSantas = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblNumTries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(132, 55);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // txbNumSantas
            // 
            this.txbNumSantas.Location = new System.Drawing.Point(12, 60);
            this.txbNumSantas.Multiline = true;
            this.txbNumSantas.Name = "txbNumSantas";
            this.txbNumSantas.Size = new System.Drawing.Size(100, 20);
            this.txbNumSantas.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeader.Size = new System.Drawing.Size(337, 22);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Welcome to the Secret Santa Generator!";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 31);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(279, 26);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Type the number of participants, and click Submit.";
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(9, 86);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(340, 225);
            this.lblOutput.TabIndex = 4;
            // 
            // lblNumTries
            // 
            this.lblNumTries.Location = new System.Drawing.Point(213, 60);
            this.lblNumTries.Name = "lblNumTries";
            this.lblNumTries.Size = new System.Drawing.Size(106, 23);
            this.lblNumTries.TabIndex = 5;
            // 
            // SecretSantaGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 509);
            this.Controls.Add(this.lblNumTries);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txbNumSantas);
            this.Controls.Add(this.btnSubmit);
            this.Name = "SecretSantaGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Santa Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txbNumSantas;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblNumTries;
    }
}