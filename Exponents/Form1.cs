using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/******************************************************
 * Name:        Jennifer Zanelli
 * Date:        7/22/2024
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:  
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

            // PROCESS
            squaredInt = (Square( Convert.ToInt32( UxInputTextBox.Text ) ));
            cubedInt = Cube( Convert.ToInt32( UxInputTextBox.Text ) );

            // OUTPUT
            xOutputLabel.Text = String.Concat( UxInputTextBox.Text," squared = ", Convert.ToString( squaredInt ), Environment.NewLine, UxInputTextBox.Text, " cubed = ", Convert.ToString( cubedInt ) );
            xOutputLabel.Visible = true;

            UxGoButton.Visible = false;
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
