namespace Exponents
{
    partial class UxExponentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxExponentsForm));
            this.UxInputTextBox = new System.Windows.Forms.TextBox();
            this.UxInputLabel = new System.Windows.Forms.Label();
            this.xOutputLabel = new System.Windows.Forms.Label();
            this.UxGoButton = new System.Windows.Forms.Button();
            this.UxResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UxInputTextBox
            // 
            this.UxInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxInputTextBox.Location = new System.Drawing.Point(165, 46);
            this.UxInputTextBox.Multiline = true;
            this.UxInputTextBox.Name = "UxInputTextBox";
            this.UxInputTextBox.Size = new System.Drawing.Size(65, 37);
            this.UxInputTextBox.TabIndex = 0;
            this.UxInputTextBox.Text = "5";
            this.UxInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UxInputLabel
            // 
            this.UxInputLabel.AutoSize = true;
            this.UxInputLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UxInputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UxInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxInputLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UxInputLabel.Location = new System.Drawing.Point(110, 7);
            this.UxInputLabel.Name = "UxInputLabel";
            this.UxInputLabel.Size = new System.Drawing.Size(174, 27);
            this.UxInputLabel.TabIndex = 3;
            this.UxInputLabel.Text = "Enter an integer:";
            this.UxInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xOutputLabel
            // 
            this.xOutputLabel.AutoSize = true;
            this.xOutputLabel.Location = new System.Drawing.Point(284, 99);
            this.xOutputLabel.Name = "xOutputLabel";
            this.xOutputLabel.Size = new System.Drawing.Size(0, 15);
            this.xOutputLabel.TabIndex = 4;
            this.xOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.xOutputLabel.Visible = false;
            // 
            // UxGoButton
            // 
            this.UxGoButton.Image = ((System.Drawing.Image)(resources.GetObject("UxGoButton.Image")));
            this.UxGoButton.Location = new System.Drawing.Point(135, 99);
            this.UxGoButton.Name = "UxGoButton";
            this.UxGoButton.Size = new System.Drawing.Size(118, 96);
            this.UxGoButton.TabIndex = 6;
            this.UxGoButton.UseVisualStyleBackColor = true;
            this.UxGoButton.Click += new System.EventHandler(this.UxGoButton_Click);
            // 
            // UxResetButton
            // 
            this.UxResetButton.Enabled = false;
            this.UxResetButton.Image = ((System.Drawing.Image)(resources.GetObject("UxResetButton.Image")));
            this.UxResetButton.Location = new System.Drawing.Point(135, 220);
            this.UxResetButton.Name = "UxResetButton";
            this.UxResetButton.Size = new System.Drawing.Size(157, 77);
            this.UxResetButton.TabIndex = 7;
            this.UxResetButton.UseVisualStyleBackColor = true;
            this.UxResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // UxExponentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 309);
            this.Controls.Add(this.UxResetButton);
            this.Controls.Add(this.UxGoButton);
            this.Controls.Add(this.xOutputLabel);
            this.Controls.Add(this.UxInputLabel);
            this.Controls.Add(this.UxInputTextBox);
            this.Name = "UxExponentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UxInputTextBox;
        private System.Windows.Forms.Label UxInputLabel;
        private System.Windows.Forms.Label xOutputLabel;
        private System.Windows.Forms.Button UxGoButton;
        private System.Windows.Forms.Button UxResetButton;
    }
}

