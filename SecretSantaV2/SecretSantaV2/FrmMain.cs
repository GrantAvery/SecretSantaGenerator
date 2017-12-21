//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="GrantAvery">
//     Copyright (c) Grant Avery. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SecretSantaV2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// The main form of the program.
    /// </summary>
    public partial class SecretSantaGenerator : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public SecretSantaGenerator()
        {
            this.InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int numTries;
            string x = txbNumSantas.Text;
            int numSantas;

            // only runs program if the user input is an int
            if (int.TryParse(x, out numSantas))
            {
                SantaGenerator.SecretSantaAssignment(numSantas, out numTries);
                lblOutput.Text = SantaGenerator.SantaOutput;
            }
        }
    }
}