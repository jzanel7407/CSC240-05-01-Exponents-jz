using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

/******************************************************
 * Name:        Jennifer Zanelli
 * Date:        7/22/2024
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:  Completed in Class
 ******************************************************/

namespace Exponents
{
    public partial class UxExponentsForm : Form
    {
        public UxExponentsForm()
        {
            InitializeComponent();
        }

        private void UxGoButton_Click( object sender, EventArgs e )
        {
            // STORAGE
            int squaredInt;
            int cubedInt;

            // INPUT
            
            try
            {
                // PROCESS
                squaredInt = (Square( Convert.ToInt32( UxInputTextBox.Text ) ));
                cubedInt = Cube( Convert.ToInt32( UxInputTextBox.Text ) );

                // OUTPUT
                xOutputLabel.ForeColor = System.Drawing.Color.Green;
                xOutputLabel.Font = new Font( "Arial", 12, FontStyle.Bold );
                xOutputLabel.Text = String.Concat( UxInputTextBox.Text, " squared = ", Convert.ToString( squaredInt ), Environment.NewLine, UxInputTextBox.Text, " cubed = ", Convert.ToString( cubedInt ) );
                xOutputLabel.Visible = true;

                UxGoButton.Visible = false;
            }

            catch (FormatException ex )
            {
                MessageBox.Show("This is not an integer. Please try again","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                UxInputTextBox.Text = " ";
            }
        }

        public int Square(int num)
        {
            return (num*num);
        }

        public int Cube(int num)
        {
            return (num*num*num);
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            UxInputTextBox.Text = " ";
            xOutputLabel.Text = " ";
            xOutputLabel.Visible = false;
            UxGoButton.Visible = true;
        }
    }
}
